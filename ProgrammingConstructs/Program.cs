namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BasicPrograms basicPrograms = new BasicPrograms();
            bool loopagain = true;
            while (true)
            {
                Console.WriteLine("\n1.Integers are equal or not\n2.Number is even or odd\n3.For vote\n4.Largest of three numbers\n5.Eligibility for Addmission" +
                    "\n6.Week day\n7.Arithmetic Operations\n8.Power of number\n9.Print sum of squares of N\n10.Factorial of number\n11.Head and tail till 20 times\n12.Sum of natural numbers\n13.Reverse aword\n14.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        basicPrograms.IntegersEqualOrNot();
                        break;
                    case 2:
                        basicPrograms.EvenOrOdd();
                        break;
                    case 3:
                        basicPrograms.Vote();
                        break;
                    case 4:
                        basicPrograms.LargestOfThrreNumbers();
                        break;
                    case 5:
                        basicPrograms.EligibilityOfAddmissions();
                        break;
                    case 6:
                        basicPrograms.WeekDay();
                        break;
                    case 7:
                        basicPrograms.ArithmeticOperations();
                        break;
                    case 8:
                        basicPrograms.PowerofTwoTable();
                        break;
                    case 9:
                        basicPrograms.SumOfSquares();
                        break;
                    case 10:
                        basicPrograms.Factorial();
                        break;
                    case 11:
                        basicPrograms.HeadTail();
                        break;
                    case 12:
                        basicPrograms.NaturalNumbers();
                        break;
                    case 13:
                        basicPrograms.ReverseWord();
                        break;
                    case 14:
                        Environment.Exit(0);
                        break;
                    case 15:
                        loopagain = false;
                        break;
                }
            }
        }
    }
}