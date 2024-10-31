namespace DoHuuHau_Lab05
{
    internal class IntTNode
    {

        public int Count { get; set; }
        public int Data { get; set; }
        public IntTNode Left { get; set; }
        public IntTNode Right { get; set; }
        public IntTNode(int x = 0)
        {
            Data = x;
            Left = null;
            Right = null;
        }
        public bool InsertNode(int x)
        {
            if (Data == x)
            {
                return false;
            }
            if (Data > x)
            {
                if (Left == null)
                {
                    Left = new IntTNode(x);
                }
                else
                {
                    return Left.InsertNode(x);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new IntTNode(x);
                }
                else
                {
                    return Right.InsertNode(x);
                }
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(Data + " ; ");
            if (Left != null)
            {
                Left.NLR();
            }
            if (Right != null) { Right.NLR(); }
        }
        public void LNR()
        {
            if (Left != null)
            {
                Left.LNR();
            }
            Console.Write(Data + " ; ");

            if (Right != null) { Right.LNR(); }

        }
        public void LRN()
        {
            if (Left != null)
            {
                Left.LRN();
            }
            if (Right != null) { Right.LRN(); }
            Console.Write(Data + " ; ");

        }
        public int CountNodeLeaf()
        {

            if (Left == null && Right == null)
            {
                return 1;

            }
            Count = 0;
            if (Left != null)
            {
                Count += Left.CountNodeLeaf();
            }
            if (Right != null)
            {
                Count += Right.CountNodeLeaf();
            }
            return Count;
        }
        public void PrintNodeLeaf()
        {
            if (Left == null && Right == null)
            {
                Console.Write(this.Data + " ");
            }
            if (Right != null)
            {
                Right.PrintNodeLeaf();
            }
            if (Left != null)
            {
                Left.PrintNodeLeaf();
            }
        }
    }
}
