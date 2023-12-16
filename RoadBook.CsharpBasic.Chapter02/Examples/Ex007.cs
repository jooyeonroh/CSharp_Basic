using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            int korean = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            int totalScore = korean + english + math + sports;

            Console.WriteLine("총 점 : " + totalScore);
            Console.WriteLine("평균 : " + totalScore / 4);
            Console.WriteLine("평균 : " + (double)totalScore / 4);
        }
    }
}
