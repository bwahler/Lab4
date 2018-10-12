using System;

namespace lab_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Num, i;
            do
            {

                Console.WriteLine("Please enter a number:");
                Num = int.Parse(Console.ReadLine());

                Console.WriteLine("Number  Squared Cubed");
                Console.WriteLine("======= ======= =======");

                for (i = 1; i <= Num; i++)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", i, "    \t", Math.Pow(i, 2), "    \t", Math.Pow(i, 3));
                }
                Console.WriteLine("Would you like to continue? (y/n)");
            }
            while (Console.ReadLine() == "y");

            if (Console.ReadLine() == "n")
                return;               
        }
    }
}

