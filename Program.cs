namespace Wk3ex1_Review;
class Program
{
    static void Main(string[] args)
    {
        //initilize the repeat variable for the do while loop
        string repeat;
        //do while loop
        do
        {
            //prompts the user for the score value
            Console.Write("What is a numeric score (0 - 100)? ");
            //initialize and store the score value
            double score = Convert.ToDouble(Console.ReadLine());
            //initialize and stores the division by ten to set the switch cases
            double scoreSegment = Math.Round(score / 10);
            //switch based on the scoreSegments
            switch (scoreSegment)
            {
                //Case and 9 get an A
                case 10:
                case 9:
                    //display grading message
                    Console.WriteLine($"The letter grade for score {score} is: A");
                    //breaks the loop
                    break;
                case 8:
                    //display grading message
                    Console.WriteLine($"The letter grade for score {score} is: B");
                    //breaks the loop
                    break;
                case 7:
                    //display grading message
                    Console.WriteLine($"The letter grade for score {score} is: C");
                    //breaks the loop
                    break;
                case 6:
                    //display grading message
                    Console.WriteLine($"The letter grade for score {score} is: D");
                    //breaks the loop
                    break;
                case 5:
                    //display grading message
                    Console.WriteLine($"The letter grade for score {score} is: E");
                    //breaks the loop
                    break;
                default:
                    //display grading message
                    Console.WriteLine($"The letter grade for score {score} is: F");
                    //breaks the loop
                    break;
            }
            //Propmt the user to score more grades
            Console.Write("Do you want to score another grade? Y/N  ");
            //stores the selection and convert it to lower case to avoid errors
            repeat = Console.ReadLine().ToLower();
        //Keeps the loop repeating until the user enters 'Y' or 'y'
        } while (repeat == "y");
        //eof message
        Console.WriteLine("Thank you for using the grade scoring system!");
        //stops the program to allow the user to read message
        Console.Read();
    }
}

