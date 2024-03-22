namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<int, int, int> countSquareNumbers = delegate (int start, int end)
            {
                int count = 0;
                for (int i = start; i <= end; i++)
                {
                    int squareRoot = (int)Math.Sqrt(i);
                    if (squareRoot * squareRoot == i)
                    {
                        count++;
                    }
                }
                return count;
            };

            int startRange = 1;
            int endRange = 100;

            int squareCount = countSquareNumbers(startRange, endRange);
            Console.WriteLine($"Number of square numbers between {startRange} and {endRange}: {squareCount}");
        }
    }
}
