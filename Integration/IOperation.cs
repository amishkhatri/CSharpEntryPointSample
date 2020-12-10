using System;
using System.Collections.Generic;
using System.Text;

namespace calc.integration
{
    public interface IOperation <T> where T : class 
    {
        float Operation(float numberX, float numberY );
     }
}
