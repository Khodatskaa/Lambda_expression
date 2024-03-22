namespace Lambda_expression
{
    internal class Program
    {
        static void Main()
        { 
            Func<int, int> cube = x => x * x * x;

            int number = 5;
            int result = cube(number);
            Console.WriteLine($"Cube of {number}: {result}");
        }
    }
}
