using System;
using System.Threading;

delegate void NumberReached(int threadNr);

namespace opdrachtweek11
{
    class Program
    {
        event NumberReached nrEvent;

        public Program()
        {
            this.nrEvent += new NumberReached(printMessage);
        }

        static void Main(string[] args)
        {
            Program prog = new Program();

            int maxVal = getMaxValInput();
            
            Thread thread1 = new Thread(() => thread1UserInput(maxVal, prog));
            thread1.Start();

            Thread thread2 = new Thread(() => thread2LoopIncrement(maxVal, prog));
            thread2.Start();

            Thread thread3 = new Thread(() => thread3Random(maxVal, prog));
            thread3.Start();
        }

        public static int getMaxValInput(){
            Console.WriteLine("Geef een max waarde");
            int val = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Max waarde ingesteld op {0}", val);
            return(val);
        }

        public static void thread1UserInput(int maxVal, Program prog){
            Console.WriteLine("Geef een max waarde");

            int enteredVal = Int32.Parse(Console.ReadLine());

            do {
                Console.WriteLine("Incoreecte max waarde");
                enteredVal = Int32.Parse(Console.ReadLine());
            } while (enteredVal != maxVal);

            prog.nrEvent(1);
        }

        public static void thread2LoopIncrement(int maxVal, Program prog){
            for (int i = 0; i <= maxVal; i++)
            {
                Console.WriteLine("Het getal is {0}", i);
                if(i == maxVal){
                    prog.nrEvent(2);
                }
            }
        }
        public static void thread3Random(int maxVal, Program prog){
            Random rnd = new Random();
            int randomVal = rnd.Next(maxVal - 10, maxVal + 10);

            do {
                
                randomVal = rnd.Next(maxVal - 10, maxVal + 10);
            } while (randomVal != maxVal);

            prog.nrEvent(3);
        }
        public static void printMessage(int a)
        {
            Console.WriteLine("Thread {0} finished", a);
        }

    }
}