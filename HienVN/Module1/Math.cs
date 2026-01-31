using System;

namespace Assignment3
{
    public class Math
    {

        public int Fibonacci(int n, bool flag)
        {
            if (flag == false)
            {
                if (n <= 1) return n;
                int a = 0, b = 1, c = 0;
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }

            return 0;
        }
    }
}