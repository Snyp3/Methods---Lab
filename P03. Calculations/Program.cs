namespace P03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toDo = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Add(toDo, numberOne, numberTwo);
            Multiply(toDo, numberOne, numberTwo);
            Subtract(toDo, numberOne, numberTwo);
            Divide(toDo, numberOne, numberTwo);

        }
        static void Add(string toDo, int numberOne, int numberTwo)
        {
            if (toDo == "add")
            {
                Console.WriteLine($"{numberOne + numberTwo}");
                
            }
        }
        static void Multiply(string toDo, int numberOne, int numberTwo)
        {
            if (toDo == "multiply")
            {
                Console.WriteLine($"{numberOne * numberTwo}");
            }
        }
        static void Subtract(string toDo, int numberOne, int numberTwo)
        {
            if (toDo == "subtract")
            {
                Console.WriteLine($"{numberOne - numberTwo}");
            }
        }
        static void Divide(string toDo, int numberOne, int numberTwo)
        {
            if (toDo == "divide")
            {
                Console.WriteLine($"{numberOne / numberTwo}");

            }
        }
    }
}