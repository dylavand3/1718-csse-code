using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intTeller, getal1 = 0, getal2 = 1, getal3;

            Console.Write(getal1.ToString() + " " + getal2.ToString() + " ");

            for (intTeller = 3; intTeller <= 10; intTeller++)
            {
                getal3 = getal1 + getal2;
                getal1 = getal2;
                getal2 = getal3;

                Console.Write(getal3.ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
