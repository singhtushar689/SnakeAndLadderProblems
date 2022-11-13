namespace SnakeAndLadder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();  
            int RollingDice = random.Next(1, 7);
            Console.WriteLine(RollingDice);
        }
    }
}