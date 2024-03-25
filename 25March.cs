
namespace _25March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Class score");
            int[] grades = {92, 88, 90, 93, 96 };
            string[] course = { "Chinese", "English", "Religion", "Art", "History" };

            double sum = 0;
            double average = 0;

            int a, b, c, d, e;
            a = grades[0];
            b = grades[1];
            c = grades[2];
            d = grades[3];
            e = grades[4];
            
            //Output using For
            Console.WriteLine("The For loop: ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Course = {course[i]}");
                Console.Write(grades[i]);
                sum += grades[i];
                average = sum / grades.Length;

                if (i < grades.Length)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine($"Average score is: {average:F2}");

            //Output using foreach
            /*
            Console.WriteLine("The Foreach loop: ");
            foreach (int i in grades)
            {
                Console.WriteLine($"course = {course}, grades = {i}");
            }
            */
            

            //string[] str = Console.ReadLine().Split
        }
    }
}
