using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Example
{
    class Work
    {
        public void Work001()
        {
            Console.WriteLine("숫자를 입력해주세요");
            int intInput = Convert.ToInt32(Console.ReadLine());

            if (intInput == 0)
            {
                Console.WriteLine("0 이쥬?");
            }
            else if (intInput > 0)
            {
                Console.WriteLine("양수쥬?");
            }
            else
            {
                Console.WriteLine("음수쥬?");
            }

            if (intInput % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public void Work002()
        {
            //영화 평점 피드백 with if
            Console.WriteLine("pls enter the name of movie");
            string movieName = Console.ReadLine();

            Console.WriteLine("pls enter the rate of movie");
            int movieRate = Convert.ToInt32(Console.ReadLine());

            //if (movieRate == 1) Console.WriteLine("{0} movie is the worst", movieName);
            //else if (movieRate == 2) Console.WriteLine("{0} movie is boring ", movieName);
            //else if (movieRate == 3) Console.WriteLine("{0} movie is just good for killing time", movieName);
            //else if (movieRate == 4) Console.WriteLine("{0} movie is high-quality as it arouse interest  ", movieName);
            //else Console.WriteLine("{0} movie is the best ", movieName);
            switch (movieRate)
            {
                case 1: 
                    Console.WriteLine("{0} movie is the worst", movieName);
                    break;
                case 2:
                    Console.WriteLine("{0} movie is boring ", movieName);
                    break;
                case 3:
                    Console.WriteLine("{0}movie is just good for killing time ", movieName);
                    break;
                case 4:
                    Console.WriteLine("{0} movie is high-quality as it arouse interest ", movieName);
                    break;
                case 5:
                    Console.WriteLine("{0} movie is the best ", movieName);
                    break;
                default:
                    Console.WriteLine("실패!");
                    break;
            }
        }
        public void work003()
        {
            Random randomInt = new Random();
            int firstInt = randomInt.Next(1,100);
            int secondInt = randomInt.Next(1,100);
            int rigthAnwer = firstInt + secondInt;

            Console.WriteLine("정답을 적어주세요 \n {0} + {1} = ",firstInt, secondInt);
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == rigthAnwer) Console.WriteLine("정답입니다!");
            else Console.WriteLine("오답입니다!");
        }
        public void work004()
        {
            Console.WriteLine("fill in your midterm score");
            int midtermScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fill in your final score");
            int finalScore = Convert.ToInt32(Console.ReadLine());
            double avgScore = (midtermScore + finalScore) / 2;

            if (avgScore <= 70) Console.WriteLine("F");
            else if (avgScore <= 80) Console.WriteLine("C");
            else if (avgScore <= 90) Console.WriteLine("B");
            else Console.WriteLine("A");

        }
    }
}
