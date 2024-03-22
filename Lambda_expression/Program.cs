namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<int[], int> countMultiplesOfSeven = arr => arr.Count(num => num % 7 == 0);

            int[] numbers = { 7, 14, 21, 28, 35, 42, 49, 5, 12, 19 };

            int count = countMultiplesOfSeven(numbers);
            Console.WriteLine($"Number of multiples of seven in the array: {count}");
        }
    }
}
