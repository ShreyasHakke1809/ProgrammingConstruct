using NLog;

namespace ProgrammingConstructs
{
    internal class BasicPrograms
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //if and else statement

        public void IntegersEqualOrNot()
        {
            Console.WriteLine("Enter two integers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                logger.Warn("");
                logger.Error("");
                Console.WriteLine("Integers are equal");
            }
            else
            {
                logger.Info("");
                Console.WriteLine("Integers are not equal");
            }
        }

        public void EvenOrOdd()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }

        public void Vote()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Eligible for voting");
            }
            else
            {
                Console.WriteLine("Not eligible for Voting");
            }
        }

        //If, Else If, Else statements

        public void LargestOfThrreNumbers()
        {
            Console.WriteLine("Enter three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number one is greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Number two is greater");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Number three is greater");
            }
            else
            {
                Console.WriteLine("All are equal");
            }
        }

        public void EligibilityOfAddmissions()
        {
            Console.WriteLine("Enter marks of Maths");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Physics");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Chemistry");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            int sum = sub1 + sub2 + sub3;
            if (sub1 >= 65 && sub2 >= 55 && sub3 >= 50 && sum >= 180)
            {
                Console.WriteLine("Candidate is eligible for addmission");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible");
            }
        }

        //Switch Case Statement

        public void WeekDay()
        {
            Console.WriteLine("Enter number");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        public void ArithmeticOperations()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which arithmetic operation you want choose option\n1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int sum = num1 + num2;
                    Console.WriteLine("Addition is " + sum);
                    break;
                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine("Addition is " + sub);
                    break;
                case 3:
                    int mul = num1 * num2;
                    Console.WriteLine("Addition is " + mul);
                    break;
                case 4:
                    int div = num1 / num2;
                    Console.WriteLine("Addition is " + div);
                    break;
            }
        }

        //For loop Statement

        public void PowerofTwoTable()
        {
            int power;
            Console.WriteLine("Please enter value of N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                power = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("2^" + i + " : " + power);
            }
        }
        public void SumOfSquares()
        {

        }
        public void Factorial()
        {
            int fact = 1;
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            // Console.WriteLine("Factorial is  " + fact);
            logger.Info("Factyorial is ", fact);
        }

        //While loop statement

        public void HeadTail()
        {
            int headscount = 0;
            int tailscount = 0;
            Random random = new Random();
            while (headscount < 20 && tailscount < 20)
            {
                int value = random.Next(2);

                if (value == 0)
                {
                    headscount++;
                }
                else
                {
                    tailscount++;
                }
            }
            Console.WriteLine("Heads Count" + headscount);
            Console.WriteLine("Tails Count" + tailscount);
            if (headscount == 20)
            {
                Console.WriteLine("Heads Win");
            }
            else
            {
                Console.WriteLine("Tails win");
            }
        }

        public void NaturalNumbers()
        {
            int sum = 0;
            int i = 1;
            while (i <= 5)
            {
                sum = sum + i;
                i++;
            }
        }
        public void ReverseWord()
        {

        }
    }
}
