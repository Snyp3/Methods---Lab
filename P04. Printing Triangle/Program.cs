namespace P04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTriangleTop(input);

            PrintTriangleBottom(input - 1);

        }

        private static void PrintTriangleBottom(int input)
        {
            for (int i = input; i >= 1; i--)
            {
                PrintTriangleLine(i);

            }
        }

        private static void PrintTriangleLine(int i)
        {
            for (int j = 1; j <= i; j++)

            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }

        private static void PrintTriangleTop(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                PrintTriangleLine(i);
            }
        }
    }
}