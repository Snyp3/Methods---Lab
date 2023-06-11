namespace P08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result = BaseRaisedToPower(firstNum, secondNum);
            Console.WriteLine(result);

        }

        static double BaseRaisedToPower (double firstNum , int secondNum)
        {
           double result = firstNum;                       // Или 
           for (int i = 1; i < secondNum; i++)       // Или 
           {                                         // Или 
                result *= firstNum;         // Или 
           }
          // result = Math.Pow(firstNum, secondNum);    // Или
            
            return result;
        }
    }
}