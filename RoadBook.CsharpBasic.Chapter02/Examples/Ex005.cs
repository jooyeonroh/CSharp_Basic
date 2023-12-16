using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex005
    {
        public void Run()
        {
            object objHello = "Hello Sarah";
            var vHello = "Hello Sarah";
            dynamic dHello = "Hello Sarah";

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.ToString().Contains("Hello");
            bool isContainsWord03 = dHello.ToString().Contains("Hello");

            Console.WriteLine("object 변수에 hello가 포함되어있다 ? {0}", isContainsWord01);
            Console.WriteLine("var 변수에 hello가 포함되어있다 ? {0}", isContainsWord02);
            Console.WriteLine("dynamic 변수에 hello가 포함되어있다 ? {0}", isContainsWord03);
        }
    }
}
