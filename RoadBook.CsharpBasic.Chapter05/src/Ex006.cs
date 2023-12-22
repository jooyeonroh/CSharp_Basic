using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src
{
    class Ex006
    {
        public void Run()
        {
            int number01 = 10;
            int number02 = 3;

            dynamic result01 = Sum(number01, number02);
            dynamic result02 = Minus(number01, number02);
            dynamic result03 = Multiple(number01, number02);
            dynamic result04 = Divide(number01, number02);

            Console.WriteLine("{0} and {1} : {2}, {3}, {4}, {5}"
                , number01
                , number02
                , result01
                , result02
                , result03
                , result04
                );
        }
        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        private int Minus(int num1, int num2)
        {
            return num1 - num2;
        }
        private int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }
        private double Divide(int num1, int num2)
        {
            return (double)num1 / num2;
        }
    }
}
