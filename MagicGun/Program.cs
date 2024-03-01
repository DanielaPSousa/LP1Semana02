using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)

        {   //Ask the user for a number
            Console.Write("Insert a number:");
            string number= Console.ReadLine();

            int i= int.Parse(number);

            int x= 0;
            while(true)
            {
                x++;

                //When the iterations align they will print both messages
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine($"{x} Magic Fire! Electric Fire!");
                }

                //Every 3 iterations, print Magic fire
                else if (x % 3 == 0)
                {
                    Console.WriteLine($"{x} Magic Fire!");
                }

                //Every 5 iteractions, print Electric Fire
                else if (x % 5 == 0)
                {
                    Console.WriteLine($"{x} Electric Fire!");
                }

                //If none of the above iterations happen, print this message
                else
                {
                    Console.WriteLine($"{x} Normal Fire :/");
                }

                if (x >= i)
                {
                    break;
                }
            }
        }
    }
}
