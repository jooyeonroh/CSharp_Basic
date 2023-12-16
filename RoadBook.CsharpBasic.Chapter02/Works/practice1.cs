using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    class practice1
    {
        public void works001()
        {
            int intInput1 = 0;
            int intInput2 = 0;
            Console.WriteLine("첫번째 입력 숫자를 넣어주세요");
            try
            {
                intInput1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("숫자를 입력하셔야죠!!!!");
            }
            
            Console.WriteLine("두번째 입력 숫자를 넣어주세요");
            try
            {
                intInput2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("숫자를 입력하셔야죠!!!!");
            }
            Console.WriteLine("첫번째 입력값이 두번째 입력값보다 큽니다 ({0})", intInput1 > intInput2);
            if(intInput1 > intInput2)
            {
                Console.WriteLine("TRUE");
            } 
        }

        public void work002()
        {
            Console.WriteLine("첫번째 숫자를 입력해주세요");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력해주세요");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("두 값의 합은 {0}", input1 + input2);
            Console.WriteLine("두 값의 합은 {0}", input1 - input2);
            Console.WriteLine("두 값의 합은 {0}", input1 * input2);
            Console.WriteLine("두 값의 합은 {0}", input1 / input2);
        }
    }
}
