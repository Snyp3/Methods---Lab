namespace P11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double result = Calculate(number,@operator, secondNumber);
            Console.WriteLine(result);


        }
         static double Calculate (int number, string @operator , int secondNumber)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = number / secondNumber;
                    break;

                case "*":
                    result = number * secondNumber;
                    break;

                case "+":
                    result = number + secondNumber;
                    break;

                case "-":
                    result = number - secondNumber;
                    break;
            }

            return result;
        }
    }
}