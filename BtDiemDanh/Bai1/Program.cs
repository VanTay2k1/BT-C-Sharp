using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a150 = Int32.Parse(Console.ReadLine());
            double b150 = Int32.Parse(Console.ReadLine());
            double c150 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a150, b150, c150);

            double delta = pt.delta(a150, b150, c150);
            int check150 = pt.nghiem(delta);
            if (check150 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check150 == 0)
            {
                double x = -b150 / (2 * a150);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b150 - Math.Sqrt(delta)) / (2 * a150);
                double x2 = (-b150 + Math.Sqrt(delta)) / (2 * a150);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }

    class ptb2
    {
        private double a150;
        private double b150;
        private double c150;

        public ptb2()
        {
        }

        public ptb2(double a150, double b150, double c150)
        {
            A = a150;
            B = b150;
            C = c150;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a150, double b150, double c150)
        {
            return b150 * b150 - 4 * a150 * c150;
        }

        public int nghiem(double delta150)
        {
            if (delta150 < 0)
            {
                return -1;
            }
            else if (delta150 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
