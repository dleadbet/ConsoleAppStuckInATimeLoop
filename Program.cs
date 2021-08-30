using System;

namespace ConsoleAppStuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            

            int length = int.Parse(Console.ReadLine());

            //Count starting from 1
            int OrderCounter = 1;
            
            
            while (length >= OrderCounter)
            {

                Console.WriteLine(OrderCounter.ToString() + " " + "Abracadabra");
                OrderCounter++;
                               

            }
            

            //Could have used a For loop instead of a while loop
            // change i to start at 1 instead of 0 
            /*
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i + " " + "Abracadabra");
            }
            */

            
        }
    }
}
