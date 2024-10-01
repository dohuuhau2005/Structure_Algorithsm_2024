// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.OutputEncoding=System.Text.Encoding.UTF8;
void main()
{
   SinhVien sv1 = new SinhVien();
    sv1.nhap();
    sv1.xuat();
    TestSinhVien();
}
 void TestSinhVien()
{
    SinhVien svA = new SinhVien();
    svA.nhap();
    Console.WriteLine("Thong tin svA:");
    svA.xuat();

    SinhVien svB = new SinhVien("18DH001",
        "Lam Thanh Ngoc",
        "CNPM", 2000, 7.6F);
    //Tiep tuc cho nhung yeu cau khac
    
}

//main();
TestSinhVien();
