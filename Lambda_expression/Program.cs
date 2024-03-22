namespace Lambda_expression
{
    public class Program
    {
        static void Main(string[] args)
        {
            var colorMap = new Dictionary<string, (int, int, int)>
        {
            { "red", (255, 0, 0) },
            { "orange", (255, 165, 0) },
            { "yellow", (255, 255, 0) },
            { "green", (0, 128, 0) },
            { "blue", (0, 0, 255) },
            { "indigo", (75, 0, 130) },
            { "violet", (238, 130, 238) }
        };

            Func<string, (int, int, int)> getRGB = color =>
            {
                color = color.ToLower(); 
                if (colorMap.TryGetValue(color, out var rgb))
                {
                    return rgb;
                }
                return (0, 0, 0); 
            };

            Console.WriteLine("RGB for Red: " + GetRGBString(getRGB("red")));
            Console.WriteLine("RGB for Orange: " + GetRGBString(getRGB("orange")));
            Console.WriteLine("RGB for Yellow: " + GetRGBString(getRGB("yellow")));
            Console.WriteLine("RGB for Green: " + GetRGBString(getRGB("green")));
            Console.WriteLine("RGB for Blue: " + GetRGBString(getRGB("blue")));
            Console.WriteLine("RGB for Indigo: " + GetRGBString(getRGB("indigo")));
            Console.WriteLine("RGB for Violet: " + GetRGBString(getRGB("violet")));
        }

        static string GetRGBString((int, int, int) rgb)
        {
            return $"({rgb.Item1}, {rgb.Item2}, {rgb.Item3})";
        }
    }
}
