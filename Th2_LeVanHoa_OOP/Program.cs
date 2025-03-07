using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2_LeVanHoa_OOP
{
    class PhanSo
    {
        private int _tuSo;
        private int _mauSo;

        // Hàm khởi tạo phân số
        public PhanSo(int ts, int ms)
        {
            if (ms == 0)
                throw new ArgumentException("Mau khac 0 !");
            _tuSo = ts;
            _mauSo = ms;
        }

        // Hàm thiết lập sao chép
        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }

        // Hàm nhập phân số từ bàn phím
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            _tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so: ");
                _mauSo = int.Parse(Console.ReadLine());
            } while (_mauSo == 0);
        }

        // Hàm xuất phân số ra màn hình
        public void Xuat()
        {
            Console.WriteLine($"{_tuSo}/{_mauSo}");
        }

        // Hàm tìm ước số chung lớn nhất (USCLN)
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // Hàm tối giản phân số
        public void ToiGian()
        {
            int uscln = USCLN(_tuSo, _mauSo);
            _tuSo /= uscln;
            _mauSo /= uscln;
        }

        // Hàm cộng hai phân số
        public PhanSo Cong(PhanSo p)
        {
            int ts = _tuSo * p._mauSo + p._tuSo * _mauSo;
            int ms = _mauSo * p._mauSo;
            return new PhanSo(ts, ms);
        }

        // Hàm trừ hai phân số
        public PhanSo Tru(PhanSo p)
        {
            int ts = _tuSo * p._mauSo - p._tuSo * _mauSo;
            int ms = _mauSo * p._mauSo;
            return new PhanSo(ts, ms);
        }
    }

    class Program
    {
        static void Main()
        {
            // Khai báo 2 đối tượng phân số
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(3, 4);

            // Nhập, xuất các phân số
            Console.WriteLine("Phan so thu nhat:");
            ps1.Xuat();
            Console.WriteLine("Phan so thu hai:");
            ps2.Xuat();

            // Tối giản phân số
            ps1.ToiGian();
            ps2.ToiGian();
            Console.WriteLine("Sau khi toi gian:");
            ps1.Xuat();
            ps2.Xuat();

            // Tính tổng, hiệu
            PhanSo tong = ps1.Cong(ps2);
            PhanSo hieu = ps1.Tru(ps2);

            Console.WriteLine("Tong hai phan so:");
            tong.ToiGian();
            tong.Xuat();

            Console.WriteLine("Hiệu hai phân số:");
            hieu.ToiGian();
            hieu.Xuat();
        }
    }
}
