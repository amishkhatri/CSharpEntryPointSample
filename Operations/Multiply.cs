﻿using System;
using calc.integration;

namespace calc.operations
{
    public class Multiply : IOperation<Multiply>
    {
        

        public float Operation(float numberX, float numberY)
        {
            try
            {
                Func<float, float, float> func = (x, y) => x * y;
                return func(numberX, numberY);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}
