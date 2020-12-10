using System;
using System.Collections.Generic;
using System.Text;

namespace calc.integration
{
    public interface IValidate<T> where T : class
    {
        bool IsValid(string Operation,string Xnumber, string Ynumber);

        bool IsOperationTypeValid(string OperationType);
    }
}