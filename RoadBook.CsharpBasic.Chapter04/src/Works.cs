using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.src
{
    class Works
    {
        public void work001()
        {
            //구구단 2단
            int defNum = 2;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("2 * {0} = {1}", i, defNum * i);
            }
        }
        public void work002()
        {
            //5! (5팩토리얼)
            int defNum = 1;
            for (int i = 5; i > 0; i-- )
            {
                defNum *= i;
                Console.WriteLine("value ={0} ", defNum);
            }
        }
        //이해도측정하자
        public void work003()
        {
            Console.WriteLine("숫자를 입력하면 팩토리얼로 계산해드림");
            int intInput = Convert.ToInt32(Console.ReadLine());

            for(int i = intInput; i > 0; i--)
            {
                intInput *= i;
                Console.WriteLine(intInput);
            }
        }
        public void work004()
        {
            Random rand = new Random();
            int targetNum = rand.Next(1, 50);

            int answer = 0;
            Console.WriteLine("Guess the Number between 1 to 50");
            int count = 0;
            while((answer = Convert.ToInt32(Console.ReadLine())) != targetNum)
            {
                if (targetNum > answer) Console.WriteLine("UP!");
                else Console.WriteLine("DOWN");
                count++;
            }
            Console.WriteLine("Correct!! You got this in {0} times", count);
        }
        public void work005()
        {
            Console.WriteLine("***********Hello, this is road bank**************** \n" +
                "1 : balance check \n" +
                "2 : deposit \n" +
                "3 : withdrawal \n" +
                "0 : exit \n" +
                "*****************************************");
            int balance = 0;
            while (true)
            {
                int reqNum = Convert.ToInt32(Console.ReadLine());
                if(reqNum == 0) { break; }
                switch (reqNum)
                {
                    case 1:
                        Console.WriteLine("your balance is {0} dollars.", balance);
                        break;
                    case 2:
                        Console.WriteLine("deposit amount");
                        balance += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("done");
                        break;
                    case 3:
                        Console.WriteLine("withdrawal amount");
                        balance -= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("done");
                        break;
                    default:
                        Console.WriteLine("please check again");
                        break;
                }
            }
            Console.WriteLine("Thanks");
        }
    }
}
