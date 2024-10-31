namespace DSLKDon
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        int count;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }

        public int Count { get => count; set => count = value; }

        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newnode)
        {
            if (IsEmpty())
                first = last = newnode;
            else
            {
                last.Next = newnode;
                last = last.Next;
            }
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                //AddFirst(newNode);
                AddLast(newNode);
                Count++;
            } while (true);
        }
        public void Input2()
        {
            int x;
            while (true)
            {
                Console.Write("Gia tri (0 ket thuc): ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) return;
                IntNode newNode = new IntNode(x);
                while (SearchX(x) != null)
                {
                    Console.WriteLine("số đã tồn tại xin nhập lại .....");
                    Console.Write("Nhap lai Gia tri (0 ket thuc): ");
                    x = Convert.ToInt32(Console.ReadLine());
                    newNode = new IntNode(x);
                    if (x == 0) return;
                }
                AddLast(newNode);
            }
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        public IntNode SearchX(int n)
        {

            IntNode x = new IntNode(n);
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x.Data)
                {

                    return x;
                }
                p = p.Next;
            }
            return null;
        }
        public IntNode GetMax()
        {

            IntNode max = new IntNode();
            IntNode p = first.Next;
            max = first;
            while (p != null)
            {
                if (p.Data > max.Data)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public IntNode GetMin()
        {

            IntNode min = new IntNode();
            IntNode p = first.Next;
            min = first;
            while (p != null)
            {
                if (p.Data < min.Data)
                {
                    min = p;
                }
                p = p.Next;
            }
            return min;
        }
        public MyList GetEvenList()
        {

            IntNode p = first;
            MyList evenList = new MyList();
            while (p != null)
            {
                if (p.Data % 2 == 0)
                {
                    IntNode k = new IntNode(p.Data);
                    evenList.AddFirst(k);
                }
                p = p.Next;
            }

            return evenList;
        }
        public MyList GetOddList()
        {

            IntNode p = first;
            MyList oddList = new MyList();
            while (p != null)
            {
                if (p.Data % 2 != 0)
                {
                    IntNode k = new IntNode(p.Data);
                    oddList.AddFirst(k);
                }
                p = p.Next;
            }
            return oddList;
        }
        public MyList JoinList(MyList list2)
        {
            MyList list3 = new MyList();
            IntNode p0 = first;
            IntNode p = list3.first;
            while (p0 != null)
            {
                IntNode k = new IntNode(p0.Data);
                list3.AddFirst(k);
                p0 = p0.Next;
            }
            IntNode p1 = list2.first;

            while (p1 != null)
            {
                IntNode k = new IntNode(p1.Data);
                list3.AddLast(k);
                p1 = p1.Next;
            }
            return list3;
        }
        public MyList JoinList2()
        {
            MyList lisChan = GetEvenList();
            MyList lisLe = GetOddList();
            MyList listJoin = new MyList();
            IntNode p1 = lisChan.first;
            IntNode p2 = lisLe.first;
            while (p1 != null && p2 != null)
            {
                IntNode newNode = new IntNode(p1.Data);
                listJoin.AddLast(newNode);
                p1 = p1.Next;
                newNode = new IntNode(p2.Data);
                listJoin.AddLast(newNode);
                p2 = p2.Next;
            }
            while (p1 != null)
            {
                IntNode newNode = new IntNode(p1.Data);
                listJoin.AddLast(newNode);
                p1 = p1.Next;
            }
            while (p2 != null)
            {
                IntNode newNode = new IntNode(p2.Data);
                listJoin.AddLast(newNode);
                p2 = p2.Next;
            }

            return listJoin;
        }
        public MyList RemoveAt(int i)
        {
            int index = 0;
            IntNode p = first;
            MyList a = new MyList();
            while (p != null)
            {
                IntNode newNode = new IntNode(p.Data);
                if (index == i)
                {
                    p = p.Next;
                    index++;
                    continue;


                }
                a.AddLast(newNode);
                index++;
                p = p.Next;
            }
            return a;


        }
        public MyList RemoveX()
        {
            Console.Write("nhap x can xoa:");
            int deleteX = Convert.ToInt32(Console.ReadLine());//TIM VI TRI SO X 
            MyList temp = new MyList();
            IntNode p = first;
            while (p != null)
            {
                IntNode newNode = new IntNode(p.Data);
                if (deleteX == p.Data)
                {
                    p = p.Next;
                    continue;
                }
                temp.AddLast(newNode);
                p = p.Next;
            }
            return temp;
        }
        public void InsertAt(int x, int i)
        {
            IntNode p = first;
            int index = 0;

            IntNode newnode = new IntNode(x);
            MyList newlist = new MyList();
            if (i == 0)
            {
                AddFirst(newnode);
            }
            while (p != null)
            {

                if (index == i)
                {
                    newlist.AddLast(newnode);
                    index++;

                    continue;
                }
                newlist.AddLast(p);
                p = p.Next;
                index++;
            }

        }
        public MyList InsertXAfterMin()
        {
            Console.Write("Nhap x can chen : ");
            IntNode insert = new IntNode(Convert.ToInt32(Console.ReadLine()));
            IntNode min = GetMin();
            IntNode p = first;
            if (IsEmpty()) Console.WriteLine("ko the chen");


            MyList newlist = new MyList();

            while (p != null)
            {
                IntNode newNode = new IntNode(p.Data);
                if (p == min)
                {
                    newlist.AddLast(newNode);
                    newlist.AddLast(insert);
                    p = p.Next;

                    continue;
                }
                newlist.AddLast(newNode);
                p = p.Next;

            }
            return newlist;
        }
        public MyList InsertXBeforeMax()
        {
            Console.Write("Nhap x can chen : ");
            IntNode insert = new IntNode(Convert.ToInt32(Console.ReadLine()));
            IntNode max = GetMax();
            IntNode p = first;
            if (IsEmpty()) Console.WriteLine("ko the chen");


            MyList newlist = new MyList();

            while (p != null)
            {
                IntNode newNode = new IntNode(p.Data);
                if (p == max)
                {

                    newlist.AddLast(insert);
                    newlist.AddLast(newNode);
                    p = p.Next;

                    continue;
                }
                newlist.AddLast(newNode);
                p = p.Next;
            }
            return newlist;
        }
        public MyList InsertXAfterY()
        {
            Console.Write("Nhap x can chen : ");
            IntNode insertx = new IntNode(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Nhap y can chen : ");
            IntNode inserty = new IntNode(Convert.ToInt32(Console.ReadLine()));
            while (SearchX(inserty.Data) == null)
            {
                Console.Write("Nhap lai y can chen : ");
                inserty = new IntNode(Convert.ToInt32(Console.ReadLine()));
            }
            MyList newlist = new MyList();
            IntNode p = first;
            while (p != null)
            {
                IntNode newnode = new IntNode(p.Data);
                if (p == inserty)
                {
                    newlist.AddLast(newnode);
                    newlist.AddLast(insertx);
                    p = p.Next;
                    continue;
                }
                newlist.AddLast(newnode);
                p = p.Next;
            }
            return newlist;
        }
        public MyList InsertXbeforeY()
        {
            Console.Write("Nhap x can chen : ");
            IntNode insertx = new IntNode(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Nhap y can chen : ");
            IntNode inserty = new IntNode(Convert.ToInt32(Console.ReadLine()));
            while (SearchX(inserty.Data) == null)
            {
                Console.Write("Nhap lai y can chen : ");
                inserty = new IntNode(Convert.ToInt32(Console.ReadLine()));
            }
            MyList newlist = new MyList();
            IntNode p = first;
            while (p != null)
            {
                IntNode newnode = new IntNode(p.Data);
                if (p == inserty)
                {
                    newlist.AddLast(insertx);
                    newlist.AddLast(newnode);

                    p = p.Next;
                    continue;
                }
                newlist.AddLast(newnode);
                p = p.Next;
            }
            return newlist;
        }
        public void ShiftLeft()
        {
            first = first.Next;
        }
        public void RShiftRight()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p == last)
                {
                    last.Data = 0;

                }
                p = p.Next;
            }
        }
        public void InterchangeSort()
        {
            IntNode p1 = first;
            IntNode p2 = first.Next;
            while (p1 != null)
            {
                while (p2 != null)
                {
                    if (p1.Data > p2.Data)
                    {
                        swap(ref p1, ref p2);
                    }
                    p1 = p2.Next;
                }
                p1 = p1.Next;
            }

        }
        public void SelectionSort()
        {

        }
        void swap(ref IntNode p1, ref IntNode p2)
        {
            IntNode temp = p1;
            p1 = p2;
            p2 = temp;

        }
    }
}
