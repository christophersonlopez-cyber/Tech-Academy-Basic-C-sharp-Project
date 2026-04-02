using MethodAssignmentSubmission;
using System;


public class Program {

    public static void Main(){
        //this line i call the class name SimpleAdd then a
        //create a object Addnumber to call the method in the class
        SimpleAdd Addnumber = new SimpleAdd();


        //then this line i call the method name addnumbers
        //to add the firstnumber and dislay thew second number in the screen
            Addnumber.addnumbers(5, 15);
        //then this line icall the parameter name and assigned a value of num1 and num2 variable

        Addnumber.addnumbers(num1: 10, num2: 15);

}

}