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
        public IntNode SearchX()
        {
            Console.Write("nhap so can tim : ");
            int n = Convert.ToInt32(Console.ReadLine());
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
    }
}
