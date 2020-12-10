using calc.domain;
using calc.validation;
using System;
using calc.integration;
using calc.operations;

namespace calc.console
{

    public class ConsoleProcessor 
    {        
        public void Execute()
        {
            string operation;
            
            validation.Validator CalculatorValidator = new validation.Validator();

            Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
            Console.WriteLine("Please enter your choice");
            operation = Console.ReadLine();

            bool validatedOpsType = CalculatorValidator.IsOperationTypeValid(operation);
            
            if (validatedOpsType)
            {                
                Console.WriteLine("Please enter first number");
                string numberX = Console.ReadLine();

                Console.WriteLine("Please enter second number");
                string numberY = Console.ReadLine();

                
                if (CalculatorValidator.IsValid(operation,numberX, numberY))
                {
                    float x, y;

                    x = float.Parse(numberX);
                    y = float.Parse(numberY);

                    switch (int.Parse(operation))
                    {
                        case (int)OperationEnum.Addition :
                            Console.WriteLine("The result is : " + new Addition().Operation(x, y).ToString());
                            break;

                        case (int)OperationEnum.Subtraction:
                            Console.WriteLine("The result is : " + new Subtraction().Operation(x, y).ToString());
                            break;

                        case (int)OperationEnum.Multiply:
                            Console.WriteLine("The result is : " + new Multiply().Operation(x, y).ToString());
                            break;

                        case (int)OperationEnum.Division:
                            Console.WriteLine("The result is : " + new Division().Operation(x, y).ToString());
                            break;
                            
                    }

                }
                else
                Console.WriteLine("Please enter a valid number");

            }
            else
                Console.WriteLine("Please enter a valid option");

        }


    }
}
