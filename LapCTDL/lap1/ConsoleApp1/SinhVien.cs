using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;

        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
        public string Loai { get => loai; set => loai = value; }

        public SinhVien()
        {
        }

        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
            this.ChuyenNganh = chuyenNganh;
            this.NamSinh = namSinh;
            this.DiemTB = diemTB;
        }
        public SinhVien(SinhVien sv)
        {
            this.MaSo = sv.MaSo;
            this.HoTen = sv.HoTen;
            this.ChuyenNganh = sv.ChuyenNganh;
            this.NamSinh = sv.NamSinh;
            this.DiemTB = sv.DiemTB;
            Loai = sv.Loai;


        }
        //method
        public bool KiemTraNamSinh(int ns)
        {
            int tuoi = DateTime.Now.Year - ns;
            if (tuoi < 17 || tuoi > 70)
            {
                return false;
            }
            return true;
        }
        public bool KiemTraDiemTB(float dtb)
        {
            if (dtb < 0 || dtb > 10)
            {
                return false;
            }
            return true;

        }
        public void nhap()
        {
            Console.Write("mời nhập mã số : ");
            MaSo = Console.ReadLine();
            Console.Write("mời nhập họ tên : ");
            HoTen = Console.ReadLine();
            Console.Write("mời nhập chuyên nghành : ");
            ChuyenNganh = Console.ReadLine();

            bool h = false;
            while (h == false)
            {

                Console.Write("mời nhập năm sinh : ");
                NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("mời nhập điểm trung bình : ");
                DiemTB = float.Parse(Console.ReadLine());
                h = KiemTraNamSinh(NamSinh);
                h = KiemTraDiemTB(DiemTB);
                if (!KiemTraNamSinh(NamSinh))
                {
                    Console.WriteLine("nhap lai");
                }


            }



        }
        public void xuat()
        {
            Console.WriteLine($"mã số : {MaSo}");
            Console.WriteLine($"họ tên: {HoTen}");
            Console.WriteLine($"chuyên nghành : {ChuyenNganh}");
            Console.WriteLine($"năm sinh : {NamSinh}");
            Console.WriteLine($"điểm trung bình : {DiemTB}");

            xeploai();
            Console.WriteLine($"Loai : {Loai}");

        }
        public void xeploai()
        {
            if (DiemTB < 5)
            {
                Loai = "Kém";
            }
            if (DiemTB >= 5 && DiemTB < 7)
            {
                Loai = "Trung bình";
            }
            if (DiemTB >= 7 && DiemTB < 8)
            {
                Loai = "Khá";
            }
            if(DiemTB >= 8 )
            {
                Loai = "Giỏi";
            }
        }
    }
}
