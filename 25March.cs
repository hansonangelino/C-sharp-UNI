namespace _25March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable for fixed grades
            //int[] grades = {92, 88, 90, 93, 96 };
            string[] course = { "Chinese", "English", "Religion", "Art", "History" };

            //Variable for manual grade input
            int grades = 0;

            //Variable 2 Dimensional Array
            int[,] stu_grades = new int[3, 5];
            string[] str = new string[5];

            //Operation average score
            double sum = 0;
            double average = 0;

            //A way to apply each array to a separated int
            /*
            int a, b, c, d, e;
            a = grades[0];
            b = grades[1];
            c = grades[2];
            d = grades[3];
            e = grades[4];
            */

            //2D Array Output and Input list [Intermediate]
            for (int i = 0; i < stu_grades.GetLength(0); i++)
            {
                str = Console.ReadLine().Split(' ');

                for (global::System.Int32 j = 0; j < stu_grades.GetLength(1); j++)
                {
                    stu_grades[i, j] = int.Parse(str[j]);
                }
            }

            //Input for manual score
            /*
            string[] newGrades = Console.ReadLine().Split(' ');
            */
            //Output using For for manual grade input
            /*
            for (int i = 0; i < newGrades.Length; i++)
            {
                grades = int.Parse(newGrades[i]);
                Console.WriteLine($"{course[i]}: {grades}");
            }
            */

            //Output using For variant 1
            /*
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
                    //Manual Input Output
                    Console.WriteLine(scrNew[0]);
                }
            }
            Console.WriteLine($"Average score is: {average:F2}");

            Console.WriteLine(scrNew[0]);
            */
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
