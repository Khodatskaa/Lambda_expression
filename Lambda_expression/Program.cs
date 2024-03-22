namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<int[], int> findMin = arr =>
            {
                int min = arr[0];
                foreach (int num in arr)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            };

            int[] numbers = { 5, 8, 9, 11, 3, 3, 55 };

            Console.WriteLine($"Minimal value in the array: {findMin(numbers)}");
        }
    }
}
