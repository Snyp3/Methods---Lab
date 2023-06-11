namespace P02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeFail(grade);
            GradePoor(grade);
            GradeGood(grade);
            GradeVeryGood(grade);
            GradeExcellent(grade);
        }
        static void GradeFail(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)             
            {
                Console.WriteLine("Fail");
            }
        }
        static void GradePoor(double grade)
        {
            if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
        }
        static void GradeGood(double grade)
        {
            if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
        }
        static void GradeVeryGood(double grade)
        {
            if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
        }
        static void GradeExcellent(double grade)
        {
            if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}