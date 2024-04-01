namespace _1April
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(5, 5);
            Console.WriteLine(p1);
            p1.setX(20);
            Console.WriteLine(p1);
        }
    }

    class Point2D { 
        private int x, y;
        
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int getX()
        {
            return x;
        }

        public void setX(int newX)  //Public if you want to make is accessible from outside of the class
        {
            this.x = newX;
        }

        public int getY()
        {
            return y;
        }

        public void setY (int newY) //Public if you want to make is accessible from outside of the class
        {
            this.y = newY;
        }

        //public static double distance(Point2D pointA, Point2D pointB)
        //{

        //}

        public override string ToString()
        {
            return $"{x},{y}";
        }
    }
}
