using System;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal, teller;
            int aantal = 0;
            int deler = 1;


            Console.Write("Geef een getal in (max 100): ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(getal <= 100)
            {
                for (teller = 1; teller <= getal; teller++)
                {
                    Console.Write(teller.ToString() + ": ");
                    aantal = 0;

                    for (deler = 1; deler <= teller; deler++)
                    {
                        if (teller % deler == 0)
                        {
                            Console.Write(deler.ToString()+ " ");

                            aantal++;
                        }
                    }

                    if (aantal == 2) {
                        Console.Write("Priemgetal");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Geen priemgetal");
            }
            Console.ReadLine();
        }
    }
}
