namespace RoadBook.CsharpBasic.Chapter03.Examples;

public class Ex001
{
    public void Run()
    {
        const int zero = 0;

        if (zero == 0)
        {
            Console.WriteLine("first if statement");
            if (zero == 0)
            {
                Console.WriteLine("second if statement");
                Console.WriteLine("printed as zero is 0");
            }
            if (zero == 1)
            {
                Console.WriteLine("Third if statement");
                Console.WriteLine("except printing as zero is not 1");
            }
        }
    }
}
