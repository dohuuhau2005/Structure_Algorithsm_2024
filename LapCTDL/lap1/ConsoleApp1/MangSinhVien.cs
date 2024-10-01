using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class MangSinhVien
    {
        SinhVien[] a;
        MangSinhVien() {
            a = null;
        }
        public MangSinhVien(SinhVien[] arraySv)
        {
            this.a = new SinhVien[arraySv.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i]=new SinhVien(a[i]);
            }
        }
        public MangSinhVien(MangSinhVien ArraySv)
        {
            this.a = new SinhVien[ArraySv.a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new SinhVien(a[i]);
            }
        }
        int NhapN()
        {
            Console.WriteLine("Nhap so phan tu : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (0 < n && n < 10000000)
                {
                    return n;
                }
            }
        }
        public void Xuat()
        {
            foreach(SinhVien a in a)
            {
                a.xuat();
            }
        }
    }
}
