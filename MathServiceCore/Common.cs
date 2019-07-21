using System;

namespace MathServiceCore
{
    public class Common
    {
        public bool IsNegative(int number)
        {
            //return false;

            return number < 0;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
