// See https://aka.ms/new-console-template for more information
using DSLKDon;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
void TestInput()
{
    MyList list = new MyList();
    list.Input();

    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("----------Menu---------");
        Console.WriteLine("1: Show");
        Console.WriteLine("2: Tim x");
        Console.WriteLine("3: Tim max");
        Console.WriteLine("4: TIm min");
        Console.WriteLine("5: danh sách chỉ chứa số chẵn");
        Console.WriteLine("6: danh sách chỉ chứa số lẻ");
        Console.WriteLine("7: nối danh sách");
        Console.WriteLine("8: exit");
        Console.WriteLine("9: Danh sách đan xen chẳng lẻ");
        Console.Write("nhập chức năng cần sử dụng : ");

        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 1)
            list.ShowList();
        if (n == 2)
        {
            Console.Write("nhap so can tim : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            IntNode k = new IntNode();
            k = list.SearchX(temp);
            if (k == null)
            {
                Console.WriteLine("không thấy x ");
            }
            else { Console.WriteLine(" đã tìm thấy x = " + k.Data); }
        }

        if (n == 3)
            Console.WriteLine(" đã tìm thấy max = " + list.GetMax().Data);
        if (n == 4)
            Console.WriteLine(" đã tìm thấy min = " + list.GetMin().Data);
        if (n == 5)
            list.GetEvenList().ShowList();
        if (n == 6)
            list.GetOddList().ShowList();
        if (n == 7)
        {
            Console.WriteLine("tạo mảng 2");
            MyList list2 = new MyList();
            list2.Input();
            list.JoinList(list2).ShowList();
        }
        if (n == 8)
        {
            Console.WriteLine("exit ? (y/n)");
            char asw = Convert.ToChar(Console.ReadLine());
            if (asw == 'y') break;
            else
                continue;


        }
        if (n == 9)
        {
            Console.WriteLine(" Danh sách đan xen chẳng lẻ ......");

            list.JoinList2().ShowList();
        }
    }
}

//TestInput();
void tes1()
{
    MyList test = new MyList();
    test.Input2();
    test.ShowList();
    test = test.RemoveX(); test.ShowList();

}
void tes2()
{
    MyList test = new MyList();
    test.Input2();
    test.ShowList();
    test.InsertAt(90, 3);
    Console.WriteLine("sho cua test");
    test.ShowList();
}
void tes3()
{
    MyList test = new MyList();
    test.Input2();
    test.ShowList();

    test = test.InsertXAfterMin();
    test.ShowList();
}
//tes3();
void tes4()
{
    MyList test = new MyList();
    test.Input2();
    test.RShiftRight();
    test.ShowList();
}
//tes4();
void tes5()
{
    MyList test = new MyList();
    test.Input2();

    test.InterchangeSort();
    test.ShowList();
}
tes5();
