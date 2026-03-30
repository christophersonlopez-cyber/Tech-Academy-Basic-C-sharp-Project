using System;
using static System.Net.Mime.MediaTypeNames;


public class Program
{
    public static void Main()
    {
        //this is an array of string
        //i decalre a variable names to hold the value of array of string
        string[] names = { "Hi", "hello", "Yoww" };

        //this part is to get the input from user and store it in a variable called input
        Console.WriteLine("Input a text you want: ");
        string input = Console.ReadLine();

        //this p[art i used a for to loop the array and add the input of the user
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + input;


        }

        //this l;ine is to print the resuklt of the array above
        Console.WriteLine("The result of array");



        //in this p[art i used foreach loop to print the result of the array after adding the input of user
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //this part i made a infinite loop and try to fix it

        // int number = 0;
        //because this code is the is is always gretaher than to number so that why always
        //print the value of i and it will be always 0 and it will be infinete loop
        // for (int i = 0; i >=number; i++)
        // {
        // Console.WriteLine(i);
        //  }

        //this code is to fix the infinete loop
        //this code is to display 1-10 number
        int number = 10;
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n");





        //this l;ine is part 3 of my assignment


        //this part i used a< operator 

        Console.WriteLine("This is the part 3 of my assignment" + "\n\n");
        int[] number2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < number2.Length; i++)
        {

            Console.WriteLine(number2[i]);

        }

        Console.WriteLine("\n\n");
        Console.WriteLine("This libne is i used a <= operator");
        //this paryt i used a <= operator

        int[] number3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i <= number3.Length - 1; i++)
        {

            Console.WriteLine(number3[i]);


        }




        //this part is used a list item is unique
        Console.WriteLine("\n\n");
        List<string> list = new List<string>() { "Blue", "Red", "White", "Pink", "Green" };
        Console.WriteLine("Input a color you want to search Color Start with Big letter: ");
        String input2 = Console.ReadLine();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == input2)
            {
                Console.WriteLine($"The item is found in the list in index: {i}");
                //this part is to break the loop if the item is found in the list
                break;
            }
            else if (i == list.Count - 1)
            {
                //this part is to print the message if the item is not found in the list and it will be print after the loop is finished
                Console.WriteLine("The item is not found in the list");
            }
        }
        //this part is to check if the item is duplicate in the list and also to check if the item is found in the list or not
        List<string> list2 = new List<string>() { "Mango", "Banana", "Apple", "Grapes", "Banana", "Mango", "Strawberry" };
        Console.WriteLine("\n\n");
        //this part is to get the input from user and store it in a variable called input3
        Console.WriteLine("Input a fruit you want to search Fruit Start with Big letter: ");
        string input3 = Console.ReadLine();
        bool found = false;
        //this part is to check if the item is duplicate in the list and also to check if the item is found in the list or not
        for (int i = 0; i < list2.Count; i++)
        {


            //this part is to check if the item is duplicate in the list
            for (int j = 0; j < list2.Count; j++)
            {

                if (i != j && list2[i] == list2[j])
                {
                    Console.WriteLine($"Index: {i}");
               
                 

                }
                if (list2[i].Equals(input3, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }


            }
          

        }
        //this part is to print the message if the item is found in the list or not
        if (found)
        {
            Console.WriteLine($"\nYour input '{input3}' is found in the list.");
        }
        else
        {
            Console.WriteLine($"\nYour input '{input3}' is not found in the list.");
        }



        Console.WriteLine("\n\n");
        Console.WriteLine("Create a list of strings that has at least two identical strings in the list.");

        //this part is to create a list of strings that has at least two identical strings in the list

        List<string> list3 = new List<string>() { "James", "JamesJR", "Doncic", "Reaves", "Smart", "Ayton", "Kennard", "James", "Doncic" };
        Console.WriteLine(" \"James\", \"JamesJR\",\"Doncic\", \"Reaves\", \"Smart\", \"Ayton\", \"Kennard\",\"James\",\"Doncic\"");
        HashSet<string> uniqueItems = new HashSet<string>();
        foreach (string item in list3) {
            if (!uniqueItems.Add(item))
            {
                Console.WriteLine($"Duplicate item found: {item}");
            }
            else
            {
                Console.WriteLine($"Unique item: {item}");
            }
        }
    }
}