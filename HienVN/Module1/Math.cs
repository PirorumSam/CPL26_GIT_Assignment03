using System;

namespace Assignment3
{
    public class Math
    {

        public int Fibonacci(int n, bool flag)
        {
            if (flag == true)
            {
                if (n <= 1) return n;
                return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
            }

            return 0;
        }
    }
}