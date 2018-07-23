using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5GrandCircus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Welcome to Factorial Calculator!");

            Console.WriteLine("\n Enter a number 1-10");

            long int  numberEnter = Console.ReadLine();
        }

        public static int getFactorial()
        {
            bool toContinue = true;
            
            while(!toContinue)
            {





                Console.WriteLine("Continue? Y/N\t ");

                var  userInput = Console.Read.key().Read.Char;

                
                if( userInput == 'Y')
                {
                    toContinue = false;

                    Console.WriteLine("See You Next Time!")
                }


            }


        }
    }
}
