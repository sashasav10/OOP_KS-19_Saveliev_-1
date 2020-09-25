using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class TTriangle
    {
        protected double a;
        protected double b;
        protected double c;
        public TTriangle()
        {
            Random ran = new Random();
            while (a + b <= c || a + c <= b || b + c <= a)
            {
                this.a = ran.Next(1, 50);
                this.b = ran.Next(1, 50);
                this.c = ran.Next(1, 50);
            }
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value + b <= c || value + c <= b || value >= b + c || value <= 0)
                {
                    Console.WriteLine("Incorrect side A entered. The triangle cannot exist.");
                }
                else a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value + a <= c || value + c <= a || value >= a + c || value <= 0)
                {
                    Console.WriteLine("Incorrect side B entered. The triangle cannot exist.");
                }
                else b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value + b <= a || value + c <= a || value >= b + a || value <= 0)
                {
                    Console.WriteLine("Incorrect side C entered. The triangle cannot exist.");
                }
                else c = value;
            }
        }
        static double Perimetr (double a, double b, double c)
        {
            return a + b + c;
        }
        static double Square (double a, double b, double c)
        {
            double polyper = (a + b + c) / 2.0;
            return Math.Sqrt(polyper * (polyper - a) * (polyper - b) * (polyper - c));
        }
        public static void Trian(double a, double b, double c)
        {
            Console.WriteLine("Length A: {0}   Length B: {1}   Length C: {2}", a, b, c);
            Console.WriteLine(" Perimetr: {0}", Perimetr(a, b, c));
            Console.WriteLine("Square: {0}", Square(a,b,c));
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle tri = new TTriangle();
            TTriangle.Trian(tri.A, tri.B, tri.C);

            Console.WriteLine("Write new length A:");
            tri.A = double.Parse(Console.ReadLine());
            TTriangle.Trian(tri.A, tri.B, tri.C);
            Console.WriteLine("Write new length B:");
            tri.B = double.Parse(Console.ReadLine());
            TTriangle.Trian(tri.A, tri.B, tri.C);
            Console.WriteLine("Write new length C:");
            tri.C = double.Parse(Console.ReadLine());
            TTriangle.Trian(tri.A, tri.B, tri.C);

            Console.ReadKey();
        }
    }
}
