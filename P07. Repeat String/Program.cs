namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str  = Console.ReadLine();
            int n = int.Parse(Console.ReadLine()); 
            string output = RepeatString(str, n);
            Console.WriteLine(output);
        }
        static string RepeatString(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        } 
    }
}