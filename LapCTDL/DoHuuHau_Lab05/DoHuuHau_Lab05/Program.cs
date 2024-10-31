using DoHuuHau_Lab05;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
void tes1()
{
    MyBinaryTree a = new MyBinaryTree();
    a.Input();
    a.InOrder();
    int k = a.FindMax();
    Console.WriteLine(k);
}
tes1();
//ListByLevel(): 
//1.	FindX()
//4.	RemoveX
