using calc.domain;
using calc.integration;
using System;
using System.Collections.Generic;
using System.Text;

namespace calc.validation
{
    public class Validator : IValidate<Validator>
    {
        public bool IsOperationTypeValid(string OperationType)
        {
            int readInput=0;
            
            Func<string, bool> func1 = x => int.TryParse(x, out readInput);
            Func<int, bool> func2 = x => { return (x >= 1 && x <= 4); } ;

            return func1(OperationType) && func2(readInput);
        }

        public bool IsValid(string Operation,string Xnumber, string Ynumber)
        {
            float parsedX = 0 ,parsedY = 0;

            Func<string, bool> func1 = x => float.TryParse(x, out parsedX);
            Func<string, bool> func2 = y => float.TryParse(y, out parsedY);

            return func1(Xnumber) && func2(Ynumber) &&  (Operation == OperationEnum.Multiply.ToString() && parsedY == 0) ? false : true ;

        }
    }
}
