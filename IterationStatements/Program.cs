namespace IterationStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintNum();
            PrintNumBy3();
            Console.WriteLine(Equality(45, 58));
            OddEven(5);
            NegativePositive(5);
            AgeCheck();
            Console.WriteLine("Give me an integer");
            int input = int.Parse(Console.ReadLine());
            InRange(input);
            MultiplicationTable(input);
        }
        //LukeWarm Section: Create methods below
        public static void PrintNum()
        { //Write a method that will print to the console all numbers 1000 through - 1000
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        public static void PrintNumBy3() //Write a method that will print to the console numbers 3 through 999 by 3 each time
        {

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool Equality(int num1, int num2) // Check if two integers are equal or not
        {
            bool isEqual;
            if (num1 == num2)
            {
                isEqual = true;
            }
            else { isEqual = false; }
            return isEqual;
        }
        public static void OddEven(int num)//Write a method to check whether a given number is even or odd
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even");
            }
            else
            {
                Console.WriteLine("not even");
            }

        }
        public static void NegativePositive(double num) //Write a method to check whether a given number is positive or negative
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            { Console.WriteLine($"{num} is negative"); }
            else
            {
                Console.WriteLine(num + " is zero");
            }
        }
        public static void AgeCheck()//Write a method to read the age of a candidate and determine whether they can vote.
        {
            int age;
            do
            {
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());

            }
            while (age < 21);
            Console.WriteLine("you can enter");
        }


        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        public static void InRange(int input) //Write a method to check if an integer(from the user) is in the range -10 to 10
        {
            if (input <= 10 && input >= -10)
            {
                Console.WriteLine($"{input} is in range");
            }
        }
        public static void MultiplicationTable(int num) //Write a method to display the multiplication table(from 1 to 12) of a given integer
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} ={num * i}");
            }
        }

        //Call the methods to test them in the Main method below
    }
}
