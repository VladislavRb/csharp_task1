using System;

namespace MyFirstCSharpProject
{
    class ISBN
    {
        public void Print_ISBN(String digits)
        {
            if (digits.Length != 9)
            {
                Console.WriteLine("Wrong digits String");
            }
            else
            {
                int digitsSum = 0;
                for (int i = 0; i < 9; i++)
                {
                    digitsSum += +digits[i];
                }

                int lastDigit = 11 - (digitsSum - 432) % 11; //432b = 48 * 9, 48 - code of '0'
                if (lastDigit == 10)
                {
                    Console.WriteLine(digits + "X");
                }
                else
                {
                    Console.WriteLine(digits + (lastDigit % 11)); // lastDigit might be eleven as well
                }
            }
        }
    }
}
