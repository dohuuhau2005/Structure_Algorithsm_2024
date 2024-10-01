namespace DSLKDon
{
    internal class IntNode
    {
        private int data;
        private IntNode next;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }

    }
}
