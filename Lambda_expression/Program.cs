namespace Lambda_expression
{
    internal class Program
    {
        static void Main()
        {
            Func<int, bool> isEven = delegate (int num)
            {
                return num % 2 == 0;
            };

            int number1 = 10;
            int number2 = 15;

            Console.WriteLine($"{number1} is {(isEven(number1) ? "even" : "odd")}");
            Console.WriteLine($"{number2} is {(isEven(number2) ? "even" : "odd")}");
        }
    }
}
