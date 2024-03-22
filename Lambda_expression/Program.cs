namespace Lambda_expression
{
    public class Program
    {
        static void Main()
        {
            Backpack myBackpack = new Backpack("Black", "Nike", "Nylon", 1.5, 20);
            myBackpack.SubscribeToAddObjectEvent();

            try
            {
                myBackpack.AddObject("Laptop", 3);
                myBackpack.AddObject("Books", 5);
                myBackpack.AddObject("Water Bottle", 1);
                myBackpack.AddObject("Jacket", 2);
                myBackpack.AddObject("Snacks", 1);

                myBackpack.AddObject("Guitar", 15);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
