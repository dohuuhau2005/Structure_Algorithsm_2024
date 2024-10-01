using lap3;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
void menu()
{
    Sach newsach = new Sach();
    newsach.Nhap();

    while (true)
    {
        Console.WriteLine();
        Console.WriteLine(" 1 : thêm sách \n 2 : hiển thị danh sách \n 3 : sắp xếp QuickSort \n 4 : sắp xếp MergeSort \n 5 : tìm kiếm sách \n 6 : Thoát Menu");
        Console.Write("mời chọn chức năng : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (n == 1)
            newsach.InsertBook();
        if (n == 2)
            newsach.Xuat();
        if (n == 3)
            newsach.use_QuickSort();
        if (n == 4)
            newsach.use_MergeSort();
        if (n == 5)
            newsach.TimSachTheoMa();
        if (n == 6)
        {
            Console.Write("Bạn muốn thoát ? (Y/N) : ");
            char asn = Convert.ToChar(Console.ReadLine());
            if (asn == 'y') break;
            if (asn == 'n') continue;
        }
    }
}
menu();