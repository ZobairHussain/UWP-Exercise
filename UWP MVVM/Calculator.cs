using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_MVVM
{
    public class Calculator
    {
        private int value1 = 0;
        private int value2 = 0;
        public Calculator(int val1, int val2)
        {
            value1 = val1;
            value2 = val2;
        }
        public int Add() { return value1 + value2; }
        public int Sub() { return value1 - value2; }
        public int Mul() { return value1 * value2; }
        public int Div() { return value1 / value2; }
    }
}
