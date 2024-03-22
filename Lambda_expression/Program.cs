namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Action<int[]> displayUniqueNegativeNumbers = arr =>
            {
                var uniqueNegativeNumbers = arr.Where(num => num < 0).Distinct();
                Console.WriteLine("Unique negative numbers in the array:");
                foreach (var num in uniqueNegativeNumbers)
                {
                    Console.WriteLine(num);
                }
            };

            int[] numbers = { -3, 7, -2, 9, -5, 1, -3, 0, -2 };

            displayUniqueNegativeNumbers(numbers);
        }
    }
}
