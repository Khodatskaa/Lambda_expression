namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<int[], int[]> findOddNumbers = (numbers) =>
            {
                List<int> oddNumbers = new List<int>();
                foreach (var number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        oddNumbers.Add(number);
                    }
                }
                return oddNumbers.ToArray();
            };

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] oddNumbers = findOddNumbers(numbers);
            Console.WriteLine(string.Join(", ", oddNumbers));
        }
    }
}
