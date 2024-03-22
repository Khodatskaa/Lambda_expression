namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<int[], int> countPositiveNumbers = arr => arr.Count(num => num > 0);

            int[] numbers = { -3, 7, -2, 9, -5, 1, 0, 6 };

            int count = countPositiveNumbers(numbers);
            Console.WriteLine($"Number of positive numbers in the array: {count}");
        }
    }
}
