using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int reversedInt = Reverse(-123);
            Console.WriteLine(reversedInt);




        }

        private static int Reverse(int x)
        {
            int rev = 0;

            while (x != 0)
            {
                var digit = x % 10;
                x = x / 10;
                if (rev > int.MaxValue / 10 ||
                  // since max value is 2,147,483,647, 
                  // last digit greater than 7 will overflow
                  (rev == int.MaxValue / 10 && digit > 7))
                    return 0;

                if (rev < int.MinValue / 10 ||
                    // since min value is  -2,147,483,648
                    (rev == int.MinValue / 10 && digit < -8))
                    return 0;

                rev = rev * 10 + digit;
            }

            return rev;
        }
    }
}