using System;
using calc.integration;
using calc.operations;
using calc.validation;

namespace calc.console
{
    public class CalculatorConsole
    {           

        //public void Process()
        //{

        //    validation.Validator validate = new validation.Validator();

        //    Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
        //    Console.WriteLine("Please enter your choice");
                       
        //    if(validate.IsOperationTypeValid(Console.ReadLine()))
        //    {
        //        Console.WriteLine("Please enter first number");
        //        string numberX = Console.ReadLine();

        //        Console.WriteLine("Please enter second number");
        //        string numberY = Console.ReadLine();

        //        if (!validate.IsValid(numberX, numberY))
        //            Console.WriteLine("Please enter a valid number");

        //    }
        //    else
        //        Console.WriteLine("Incorrect choice");

        //}

        [STAThread]
        private static void Main(string[] args) 
        {
            ConsoleProcessor c = new ConsoleProcessor();
            c.Execute();

        }
    }

   


}

