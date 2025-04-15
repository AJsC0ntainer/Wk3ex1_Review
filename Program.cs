namespace Wk3ex1_Review;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is a numeric score (0 - 100)? ");
        double score = Convert.ToDouble(Console.ReadLine());

        double scoreSegment = Math.Round(score / 10);

        switch (scoreSegment)
        {
            case 10:
            case 9:
                Console.WriteLine($"The letter grade for score {score} is: A");
                break;
            case 8:
                Console.WriteLine("B");
                break;
            case 7:
                Console.WriteLine("C");
                break;
            case 6:
                Console.WriteLine("D");
                break;
            case 5:
                Console.WriteLine("E");
                break;
            default:
                break;

        }

        Console.Read();
    }
}

