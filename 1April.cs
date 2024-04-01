namespace _1April
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(5, 5);
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

        void setX(int newX)
        {
            this.x = newX;
        }

        public int getY()
        {
            return y;
        }

        void setY (int newY)
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
