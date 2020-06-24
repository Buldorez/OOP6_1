using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            num numo = new num(1);
            numo.print();
            num nump = new num(2, 3);
            nump.print();
            Console.ReadLine();
        }
        class num
        {
            private int num1;
            private int num2;

            public num()
            {
            }

            public num(int number1)

            {
                num1 = number1;
            }

            public num(int number1, int number2)
            {
                num1 = number1;
                num2 = number2;
            }

            public void print()
            {
                Console.WriteLine(num1 +"|"+ num2);
            }
        }

    }
    }

