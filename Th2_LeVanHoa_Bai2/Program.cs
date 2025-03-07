using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2_LeVanHoa_Bai2
{
    class PhanSo
    {
        private int _tuSo;
        private int _mauSo;

        public PhanSo(int ts = 0, int ms = 1)
        {
            if (ms == 0)
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            _tuSo = ts;
            _mauSo = ms;
            ToiGian();
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            _tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập mẫu số (khác 0): ");
                _mauSo = int.Parse(Console.ReadLine());
            } while (_mauSo == 0);
            ToiGian();
        }

        public void Xuat()
        {
            Console.WriteLine($"{_tuSo}/{_mauSo}");
        }

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

        public void ToiGian()
        {
            int uscln = USCLN(_tuSo, _mauSo);
            _tuSo /= uscln;
            _mauSo /= uscln;
        }

        public double GiaTri()
        {
            return (double)_tuSo / _mauSo;
        }
    }

    class DSPHanSo
    {
        private PhanSo[] _dsPS;
        private int _size;

        public DSPHanSo(int size)
        {
            _size = size;
            _dsPS = new PhanSo[_size];
        }

        public void NhapDS()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"Nhập phân số thứ {i + 1}:");
                _dsPS[i] = new PhanSo();
                _dsPS[i].Nhap();
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("Danh sách phân số:");
            foreach (var ps in _dsPS)
            {
                ps.Xuat();
            }
        }

        public PhanSo TimMax()
        {
            PhanSo maxPS = _dsPS[0];
            foreach (var ps in _dsPS)
            {
                if (ps.GiaTri() > maxPS.GiaTri())
                    maxPS = ps;
            }
            return maxPS;
        }

        public void SapXepTangDan()
        {
            Array.Sort(_dsPS, (a, b) => a.GiaTri().CompareTo(b.GiaTri()));
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            DSPHanSo dsPhanSo = new DSPHanSo(n);
            dsPhanSo.NhapDS();
            dsPhanSo.XuatDS();

            Console.WriteLine("Phân số lớn nhất:");
            dsPhanSo.TimMax().Xuat();

            dsPhanSo.SapXepTangDan();
            Console.WriteLine("Danh sách phân số sau khi sắp xếp tăng dần:");
            dsPhanSo.XuatDS();
        }
    }
}
