using Casino;
using Casino.TwentyOne;
using System;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Collections.Generic;



namespace TwentyOne
{
    class Program
    {
      

        static void Main()
        {


            const string casinoName = "Grand Hotel and Casino";



            Console.WriteLine("Welcome to the {0}. Let's start by telling your name!", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }



            Console.WriteLine("Hello, {0} Wpuld you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {

                Player player = new(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new(@"C:\Users\frond\OneDrive\Documents\GitHub\Tech-Academy-Basic-C-sharp-Project\logs.txt", true))
                {
                    file.WriteLine(player.Id);

                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {

                    try

                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security kick this Person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }

                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();



        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = "Data Source = (localdb)\\ProjectModels; Initial Catalog = TwentyOneGame;" +
                                      " Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False;" +
                                      " Application Intent = ReadWrite; Multi Subnet Failover = False";

            string queryString = "INSERT INTO Exception(ExceptionType, ExceptionMessage, TimeStamp) VALUES " +
                                 "(@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using(SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand mycom = new SqlCommand(queryString, connect);
                mycom.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar).Value = ex.GetType().ToString();
                mycom.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar).Value = ex.Message;
                mycom.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime).Value = DateTime.Now;

                connect.Open();
                mycom.ExecuteNonQuery();

            }
        }
    }
}

