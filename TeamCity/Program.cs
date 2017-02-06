using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity
{
    class Program
    {
        public static float firstNumber { get; set; }

        public static float SecondNumber { get; set; }

        static void Main(string[] args)
        {
			//Test comment test
			// new line
			// one
			// two
			// three
			// four
			// five
			// six
			// seven
            Console.WriteLine("Enter two number");
            firstNumber =float.Parse(Console.ReadLine());
            SecondNumber = float.Parse(Console.ReadLine());

            bool x; 
            float result = sum(firstNumber, SecondNumber);
            if (result == ( firstNumber + SecondNumber ))
            {
                x = true;
            }
            else
            {
                x = false;
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }

        private static float sum(float first , float second)
        {
            return first + second;
        }
    }
}
