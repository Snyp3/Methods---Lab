namespace P01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            PositiveNumber(i);
            NegativeNumber(i);
            ZeroNumber(i);
        }
        static void PositiveNumber(int i)
        {

            if (i > 0)
            {
                Console.WriteLine($"The number {i} is positive. ");
            }
        }
        static void NegativeNumber(int i)
        {
            if (i < 0)
            {
                Console.WriteLine($"The number {i} is negative. ");
            }
        }
        static void ZeroNumber(int i) 
        {
            if (i == 0)
            {
                Console.WriteLine($"The number {i} is zero. ");
            }
        }

    }
}