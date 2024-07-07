namespace RoadBook.CsharpBasic.Chapter03.Examples;

public class Ex006
{
    public void Run()
    {
        Console.WriteLine("type any number");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("It is a negative number");
        }
        else if (number == 0)
        {
            Console.WriteLine("It is ZERO");
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine("It is a EVEN Number");
        }
        else
        {
            Console.WriteLine("It is a ODD Number");
        }
    }
}
