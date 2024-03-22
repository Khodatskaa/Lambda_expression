namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Func<string, string, bool> containsWord = (text, word) =>
            {
                return text.ToLower().Contains(word.ToLower());
            };

            string text = "This is a sample text for testing the lambda expression.";
            string wordToCheck = "sample";

            bool wordExists = containsWord(text, wordToCheck);
            Console.WriteLine($"Does the text contain the word '{wordToCheck}'? {wordExists}");
        }
    }
}
