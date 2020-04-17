using System;
using System.Linq;

namespace MyFirstCSharpProject
{
    class NumbersWithFourOnes
    {
        public void PrintNumbersWithFourOnes(int a, int b)
        {
            for (int number = a; number <= b; number++)
            {
                if (number > 0)
                {
                    String binary = Convert.ToString(number, 2);
                    int ones = binary.Count(ch => ch == '1');
                    if (ones == 4)
                    {
                        Console.Write(number);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
