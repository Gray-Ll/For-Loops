namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Countdown");

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(1 + i);
            }
            Console.WriteLine("Blast offf!");

            Console.WriteLine();

            Console.WriteLine("x         y");

            for (int i = -10; i <= 10; i = i + 2)
            {
                Console.Write(i);
                Console.WriteLine("\t" + (i * i));
            }

            Console.WriteLine();
            Console.WriteLine("Enter your name:");
            string name = Convert.ToString(Console.ReadLine());

            if (name.ToLower() == "aldworth")
            {
                for (int i = 0; i <= 4; i = i + 1)
                {
                    Console.WriteLine(i + 1 + "." + name);
                }
            }
            else
            {
                for (int i = 0; i <= 9; i = i + 1)
                {
                    Console.WriteLine(i + 1 + "." + name);
                }
            }
        }
    }
}
