using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.src
{
    class Examples
    {
        public void ex001()
        {
            //증감연산자의 흐름
            int number = 10;

            Console.WriteLine("number" + number);
            Console.WriteLine("number++" + number++);
            Console.WriteLine("number" + number);
            Console.WriteLine("++number" + ++number);
            Console.WriteLine("number" + number);
        }
        public void ex006()
        {
            //증감연산자의 흐름
            int number = 10;

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("i:{0} / j:{1} / k{2}", i, j, k);
                    }
                }
            }
        }
        public void ex007()
        {
            for(int i = 2; i < 10; i++)
            {
                Console.WriteLine("Multiplication {0}", i);
                for(int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                }
            }
        }
        public void ex008()
        {
            Random rand = new Random();
            int target_num = rand.Next(1, 10);

            Console.WriteLine("Guess what number am I thinking?");

            int count = 0;
            while(Convert.ToInt32(Console.ReadLine()) != target_num)
            {
                Console.WriteLine("땡");
                count++;
            }
            Console.WriteLine("딩동댕. {0}번만에 맞췄네용?",count);
        }
        public void ex009()
        {
            Random rand = new Random();
            int target_num = rand.Next(1, 10);

            Console.WriteLine("guess the number between 1 and 10 \n (enter 0 for hint)");

            int count = 0;
            int answer = 0;
            while ((answer = Convert.ToInt32(Console.ReadLine())) != target_num)
            {
                if (answer == 0)
                {
                    Console.WriteLine("hint : that's divided by two, the rest is {0}", target_num % 2);
                    continue;
                }
                Console.WriteLine("Wrong");
                count++;
            }

            Console.WriteLine("correct! you tried {0}times", count);
        }

        public void ex010()
        {
            Random rand = new Random();
            int target = rand.Next(1, 10);

            Console.WriteLine("guess the number between 1 and 10");

            int count = 0;
            bool isMatched = false;

            do
            {
                if (Convert.ToInt32(Console.ReadLine()) == target)
                {
                    isMatched = true;
                    Console.WriteLine("correct. You tried {0} times", count);
                }
                else
                {
                    Console.WriteLine("Wrong");
                    count++;
                } 
            } while (isMatched == false);
        }
    }
}
