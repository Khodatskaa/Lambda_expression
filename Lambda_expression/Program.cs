namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

            DateTime testDate1 = new DateTime(2024, 9, 12); 
            DateTime testDate2 = new DateTime(2024, 9, 13); 

            Console.WriteLine($"{testDate1.ToShortDateString()} is Programmer's Day: {isProgrammersDay(testDate1)}");
            Console.WriteLine($"{testDate2.ToShortDateString()} is Programmer's Day: {isProgrammersDay(testDate2)}");
        }
    }
}
