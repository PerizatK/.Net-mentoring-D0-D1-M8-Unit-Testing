using System;
using System.Text;

namespace M8Project
{
    public class FizzBuzz
    {
        public StringBuilder Print(int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sb.Append("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    sb.Append("Fizz");
                }
                else if (i % 5 == 0)
                {
                    sb.Append("Buzz");
                }
                else
                {
                    sb.Append(i);
                }
            }

            return sb;
        }
    }
}
