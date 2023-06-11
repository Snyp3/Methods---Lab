using System.Collections.Generic;

namespace P09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int one = int.Parse(Console.ReadLine());
                int two = int.Parse(Console.ReadLine());
                GetMaxInt(one, two);
            }
            else if (type == "char")
            {

                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());
                Console.WriteLine (GetMaxChar(one, two));
            }
            else if (type == "string")
            {
                string one = Console.ReadLine();
                string two = Console.ReadLine();
                Console.WriteLine(GetMaxString(one, two));
            }
        }

        static int GetMaxInt(int one, int two)
        {
            int result = 0;
            {
                if (one > two)
                {
                    result = one;
                }
                else
                {
                    result = two;
                }
                Console.WriteLine(result);
                return result;
            }
        }
        static char GetMaxChar(char one, char two)
        {


            return (char)Math.Max(one, two);
        }
        
        static string GetMaxString (string one , string two)
        {
            
            int comparison = one.CompareTo(two);

            if (comparison > 0)
            {
                return one;
            }
            else
            {
                return two;
            }

          
        }
            
        
    }
}