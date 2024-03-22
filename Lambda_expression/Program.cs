namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<int[], int> findMax = arr =>
            {
                int max = arr[0];
                foreach (int num in arr)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return max;
            };

            int[] numbers = { 5, 8, 9, 11, 3, 3, 55 };

            Console.WriteLine($"Maximum value in the array: {findMax(numbers)}");
        }
    }
}
