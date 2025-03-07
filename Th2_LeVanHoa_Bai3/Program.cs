using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2_LeVanHoa_Bai3
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        // Hàm Move

        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        // Tính khoảng cách từ điểm hiện tại đến gốc tọa độ (0,0)
        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        // Tính khoảng cách giữa hai điểm
        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }

        public void Print()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Nhập số lượng điểm: ");
            int n = int.Parse(Console.ReadLine());

            // Dùng mảng bình thường để lưu danh sách điểm
            Point[] points = new Point[n];

            // Nhập danh sách điểm
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập tọa độ x của điểm {i + 1}: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write($"Nhập tọa độ y của điểm {i + 1}: ");
                double y = double.Parse(Console.ReadLine());

                points[i] = new Point(x, y);
            }

            // In danh sách điểm
            Console.WriteLine("\nDanh sách tọa độ các điểm:");
            foreach (var p in points)
            {
                p.Print();
            }

            // Tìm điểm gần gốc tọa độ nhất
            Point minPoint = points[0];
            foreach (var p in points)
            {
                if (p.DistanceToOrigin() < minPoint.DistanceToOrigin())
                {
                    minPoint = p;
                }
            }
            Console.WriteLine("\nĐiểm gần gốc tọa độ nhất:");
            minPoint.Print();

            // Tìm cặp điểm gần nhau nhất
            double minDistance = double.MaxValue;
            Point p1 = null, p2 = null;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        p1 = points[i];
                        p2 = points[j];
                    }
                }
            }

            Console.WriteLine("\nCặp điểm gần nhau nhất:");
            p1.Print();
            p2.Print();
            Console.WriteLine($"Khoảng cách: {minDistance}");
        }
    }
}
