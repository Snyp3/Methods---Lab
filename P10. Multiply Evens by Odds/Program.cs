namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs (int.Parse(Console.ReadLine()));
           

            int even = 0;
            int odd = 0;
           
            int total = GetMultipleOfEvenAndOdds(num,even,odd);
            Console.WriteLine(total);
        }

        static int GetMultipleOfEvenAndOdds(int num, int even, int odd)
        {
            int sumEven = GetSumOfEvenDigits(num, even);
            int sumOdd = GetSumOfOddDigits(num, odd);

            int totalMultiple = sumEven * sumOdd;

            return totalMultiple;
        }

        static int GetSumOfEvenDigits(int num, int even)
        {

            while (num > 0)
            {
                int nextNumb = num % 10;
                num /= 10;
                if (nextNumb % 2 == 0)
                {
                    even += nextNumb;
                }

            }
            return even;
        }

        static int GetSumOfOddDigits(int num , int odd)
        {
            while (num > 0)
            {
                int nextNumb = num % 10;
                num /= 10;
                if (nextNumb % 2 == 1)
                {
                    odd += nextNumb;
                }

            }
            return odd;
        }
    }
}