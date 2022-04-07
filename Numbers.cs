using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        private int i, j;
        public int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            i = number1 < number3 ? number1 : (int)number3;
            j = number1 < number2 ? number1 : (int)number3;
            return number1 < number2 ? i : j;
        }
        public int FindMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            i = number1 > number3 ? number1 : (int)number3;
            j = number1 > number2 ? number1 : (int)number3;
            return number1 > number2 ? i : j;
        }
    }
}
