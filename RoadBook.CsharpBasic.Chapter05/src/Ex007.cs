﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src
{
    class Ex007
    {
        public void Run()
        {
            dynamic result = Sum(1, 2, 3, 4, 5);
            Console.WriteLine("Sum of 1 to 5 is {0}", result);
        }
        private int Sum(params int[] number)
        {
            int result = 0;

            for (int idx = 0; idx < number.Length; idx++)
            {
                result += number[idx];
            }
            return result;
        }
    }
}
