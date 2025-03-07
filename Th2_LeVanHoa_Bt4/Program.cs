using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2_LeVanHoa_Bt4
{
    // Lớp Point mô tả một điểm trong hệ tọa độ 2D
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    // Lớp Circle mô tả hình tròn
    class Circle
    {
        public double R { get; set; } // Bán kính
        public Point C { get; set; }  // Tâm hình tròn

        public Circle(double r, Point c)
        {
            R = r;
            C = c;
        }

        public double Area()
        {
            return Math.PI * R * R;
        }

        public void Move(double dx, double dy)
        {
            C.Move(dx, dy);
        }

        public override string ToString()
        {
            return $"Circle(Radius: {R}, Center: {C})";
        }
    }

    // Chương trình chính kiểm tra
    class Program
    {
        static void Main()
        {
            // Tạo một số hình tròn
            Circle circle1 = new Circle(5, new Point(0, 0));
            Circle circle2 = new Circle(3, new Point(2, 2));

            Console.WriteLine("Ban đầu:");
            Console.WriteLine(circle1);
            Console.WriteLine(circle2);

            // Di chuyển hình tròn
            circle1.Move(2, 3);
            circle2.Move(-1, 4);

            Console.WriteLine("\nSau khi di chuyển:");
            Console.WriteLine(circle1);
            Console.WriteLine(circle2);

            // Tính diện tích
            Console.WriteLine("\nDiện tích của từng hình tròn:");
            Console.WriteLine($"Circle 1: {circle1.Area():F2}");
            Console.WriteLine($"Circle 2: {circle2.Area():F2}");
        }
    }
}
