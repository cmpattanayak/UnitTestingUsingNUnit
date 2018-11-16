using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestExample
{
    public class Calculator
    {
        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Subtract(float a, float b)
        {
            return a - b;
        }

        public float Multiply (float a, float b)
        {
            return a * b;
        }

        //Private Method for testing
        private int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
