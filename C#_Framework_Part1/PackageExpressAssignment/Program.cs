// See https://aka.ms/new-console-template for more information
using System;


public class PackageExpress
{
    public static void Main()
    {

        //this line of code is to dosplay the welcome message to the user when they run the program
        Console.WriteLine("Hello, Welcome to package Express\n\n");


        //yhis part of the code is to ask the user to enter the package weight and then convert it to an integer so we can use it in our calculations later on
        Console.WriteLine("Please enter the package weight: \n");
        int weight = Convert.ToInt32(Console.ReadLine());

        int maxWeight = 50;
        //this part of the code is to check if the package weight is less than or equal to the maximum weight  if the weight is less than or equal to the maximum weight then we proceed to statemet below
       
        if (weight <= maxWeight)
        {
            //if the condition is trrue then user ask the width, height and length of the package and convert them to double so we can use them in our calculations later on
            Console.WriteLine("Please enter the package width: \n");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height: \n");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length: \n");
            double length = Convert.ToDouble(Console.ReadLine());
            //this part i create a variiable to hold the total of the width, height and length of the package so we can use it in our calculations later on
            double totaladd = width + height + length;


            //then this condityion is to check if the total of the width, height and length of the package is less than
            //or equal to 50 if the total is less than or equal to 50 then we proceed to statemet below
            if (totaladd <= 50)
            {
                //this code is true if the the total of the width, height and length of the package is less than or equal to 50 then we proceed to statemet below



                //this code is to calculate the total of the width, height, length and weight of the package and then divide it by 100 to get the estimated total for shipping the package and then display it to the user
                double totalreult = (width * height * length * weight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + totalreult);
                Console.WriteLine("Thank you!");
            }
            else
            {
                //this part if the condtion is false if the total of the width, height and length of the package is greater than 50 then we display this message to the user and then end the program
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                return;
            }



        }
        else {

            //this line of code is to display this message to the user if the condition is false if the package weight is greater than
            //the maximum weight then we display this message to the user and then end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
           return;
        }



    }
}
