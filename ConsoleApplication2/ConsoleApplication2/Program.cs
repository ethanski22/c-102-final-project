using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static readonly bool Answer;

        static void Main(string[] args)
        {
            Console.WriteLine("Aloha!(That means hello in hawii) This is a calculator! You can Add,Subtract,Multiply,Divide,Exponent, or Take the Root of--Press Enter");
            Console.WriteLine("What Would You like to do");
            Console.WriteLine("1.) Add");
            Console.WriteLine("2.) Subtract");
            Console.WriteLine("3.) Multiply ");
            Console.WriteLine("4.) Divide");
            Console.WriteLine("5.) Exponent");
            Console.WriteLine("6.) Take Root Of");
            Console.WriteLine();
            String Action =  Console.ReadLine();

            if (Action == "1")
            {
                Console.WriteLine("O.K. Give me the first number you would like to add!");
                double addFirst = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("OK Second number!!!!");
                double addSecond = Convert.ToDouble(Console.ReadLine());
                double Answer = (addFirst + addSecond);
                Console.WriteLine(Answer);
                Console.ReadLine();
            }
            else if (Action == "2")
            {
                Console.WriteLine("O.K. Give me the first number you would like to subtract!");
                double subFirst = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("OK Second number!!!!");
                double subSecond = Convert.ToDouble(Console.ReadLine());
                double Answer = (subFirst - subSecond);
                Console.WriteLine(Answer);
                Console.ReadLine();

            } else if (Action == "3")
            {
                Console.WriteLine("O.K. Give me the first number you would like to Multiply!");
                double MultFirst = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("OK Second number!!!!");
                double MultSecond = Convert.ToDouble(Console.ReadLine());
                double Answer = (MultFirst * MultSecond);
                Console.WriteLine(Answer);
                Console.ReadLine();
            } else if (Action == "4")
            {
                Console.WriteLine("O.K. Give me the first number you would like to Divide!");
                double divFirst = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("OK Second number!!!!");
                double divSecond = Convert.ToDouble(Console.ReadLine());
                double Answer = (divFirst / divSecond);
                Console.WriteLine(Answer);
                Console.ReadLine();

            } else if(Action == "5")
            {
                Console.WriteLine("OK What number is your base?");
                double bas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your exponent");
                double exponent = Convert.ToDouble(Console.ReadLine());
                double Answer = 0;
                double base2 = bas;
                while (exponent >= 2)
                
                {
                     base2 = (base2 * bas);
                     exponent = (exponent - 1);
                    Answer = base2;                              

                }

                Console.WriteLine(Answer);
                Console.ReadLine();
            }else if (Action == "6")
            {
                Console.WriteLine("O.K. Whar Number do you want to be in the root symbol!");
                double inN = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("OK what number will be taking the root!!!!");
                double outN = Convert.ToDouble(Console.ReadLine());
                double Answer = 0;
                double outN2 = outN;
                 int n1 = 0;
                while (outN2 <= inN)

                {
                    outN2 = outN2 * outN;
                    Answer = outN2;
                    Console.WriteLine(n1++);
                }
                
                Console.ReadLine();

            }
            

            }
       }

    }

