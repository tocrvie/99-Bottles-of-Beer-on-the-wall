using System;

namespace _99_Bottles_of_Beer_On_the_Wall
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 99; i > 0; i--) 
            {
                int k = i - 1;

                if (k==1)
                {
                    Console.WriteLine("  {0} , bottles of beer on the wall, {0}  bottles of beer. Take one down and pass it around, {1}  bottle of beer on the wall.\n\n", i, k);
                }
                else if (k==0)
                {
                    Console.WriteLine("  {0} , bottle of beer on the wall, {0}  bottle of beer. Take one down and pass it around, {1}  bottle of beer on the wall.\n\n", i, k);
                }
                else
                {
                    Console.WriteLine("  {0} , bottles of beer on the wall, {0}  bottles of beer. Take one down and pass it around, {1}  bottles of beer on the wall.\n\n", i, k);

                }
            }
        }
    }
}
