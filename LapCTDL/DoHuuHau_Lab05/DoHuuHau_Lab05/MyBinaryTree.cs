namespace DoHuuHau_Lab05
{
    internal class MyBinaryTree
    {
        public IntTNode Root { get; set; }
        public MyBinaryTree()
        {
            Root = null;
        }
        private bool Insert(int x)
        {
            if (Root == null)
            {
                Root = new IntTNode(x);
                return true;
            }


            return Root.InsertNode(x);


        }
        public void Input()
        {
            int x;
            while (true)
            {
                Console.Write("Mời Nhập phần tử cho cây ( nhập trùng sẽ thoát ) : "); x = Convert.ToInt32(Console.ReadLine());
                if (Insert(x) == true)
                {
                    Console.WriteLine("Đã Thêm");
                }
                else
                {
                    Console.WriteLine("Ket thuc");
                    break;
                }
            }
        }
        public void PreOrder()
        {
            if (Root == null) { return; }
            Root.NLR();
            Console.WriteLine();
        }
        public void InOrder()
        {
            if (Root == null) { return; }
            Root.LNR();
            Console.WriteLine();

        }
        public void PostOrder()
        {
            if (Root == null) { return; }
            Root.LRN();
            Console.WriteLine();

        }
        public int FindMax()
        {
            IntTNode a;
            while (Root.Right != null)
            {
                Root = Root.Right;
            }
            a = Root;
            int k = a.Data;
            return k;
        }
        public int FindMin()
        {
            IntTNode a;
            while (Root.Left != null)
            {
                Root = Root.Left;
            }
            a = Root;
            int k = a.Data;
            return k;
        }
        public void CountLeaf()
        {
            if (Root == null) { Console.WriteLine("ko co leaf, cay rong "); return; }
            int count = Root.CountNodeLeaf();



            Console.WriteLine("cay co " + count + " leaf !!");
        }
        public void ListLastLevel()
        {
            if (Root == null) { Console.WriteLine("ko co leaf, cay rong "); return; }
            Root.PrintNodeLeaf();
        }
    }
}
