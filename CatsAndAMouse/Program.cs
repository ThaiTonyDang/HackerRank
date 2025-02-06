namespace CatsAndAMouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static string CatAndMouse(int x, int y, int z)
        {
            int distanceA = Math.Abs(x - z);

            int distanceB = Math.Abs(y - z);

            if (distanceA < distanceB)
            {
                return "Cat A";
            }
            else if (distanceB < distanceA)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }
    }
}
