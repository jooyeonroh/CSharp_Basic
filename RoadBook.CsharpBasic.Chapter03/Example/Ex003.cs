using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Example
{
    class Ex003
    {
        public void Run()
        {
            const int zero = 0;

            if(zero == 0)
            {
                Console.WriteLine("첫번째 if문");
            }
            else
            {
                Console.WriteLine("첫번째 else문");
            }

            if (zero == 1)
            {
                Console.WriteLine("두번째 if문");
            }
            else
            {
                Console.WriteLine("두번째 else문");
            }

        }
    }
}
