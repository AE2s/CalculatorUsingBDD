using System;
using System.Collections.Generic;
using System.Text;

namespace BDDCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Substract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }
    }
}
