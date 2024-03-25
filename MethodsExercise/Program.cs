using System.ComponentModel.DataAnnotations;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        
        }

        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply (int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1/num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            Console.WriteLine("Sum function numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int addAnswer = Sum(num1, num2);
            Console.WriteLine($"The answer is: {addAnswer}");

            Console.WriteLine("Subtraction function numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int subAnswer = Subtraction(num1, num2);
            Console.WriteLine($"The answer is: {subAnswer}");

            Console.WriteLine("Multiply function numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int mulAnswer = Multiply(num1, num2);
            Console.WriteLine($"The answer is: {mulAnswer}");

            Console.WriteLine("Divide function numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int divAnswer = Divide(num1, num2);
            Console.WriteLine($"The answer is: {divAnswer}");

            Console.WriteLine("Modulus function numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int modAnswer = Modulus(num1, num2);
            Console.WriteLine($"The answer is: {modAnswer}");

        }
    }
}
