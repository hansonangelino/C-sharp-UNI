using System;
namespace _18March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a number");
            int Date = int.Parse(Console.ReadLine());
            switch (Date)
            {
                case 0:
                    Console.WriteLine("Weekdays");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sundays");
                    break;
                case 8:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            */
            for (int j = 1; j < 11; j++)
            {
                //Console.WriteLine(j);
            }

            int sum = 0;
            for (int a = 1; a < 11; a++)
            {
                //sum += a;
                //Console.WriteLine($"a = {a:D2}, sum = {sum:D2}");
            }

            int sum2 = 0;
            int input = 0;
            input = int.Parse(Console.ReadLine());
            /*
            while (input != 0)
            {
                sum2 += input;
                Console.WriteLine(sum2);
                input = int.Parse(Console.ReadLine());
            }*/
            do
            {
                sum2 += input;
                input = int.Parse(Console.ReadLine());
            } while (input != 0);
            Console.WriteLine("sum = " + sum2);
        }
    }
}
