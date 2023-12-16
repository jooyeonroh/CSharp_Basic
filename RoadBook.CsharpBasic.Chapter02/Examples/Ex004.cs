using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex004
    {
        public void Run()
        {
            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;

            Console.WriteLine("object : {0}", objValue);
            Console.WriteLine("var : {0}", vValue);
            Console.WriteLine("dynamic : {0}", dValue);
        }
    }
}
