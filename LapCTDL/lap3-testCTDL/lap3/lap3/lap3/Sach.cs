namespace lap3
{
    internal class Sach
    {
        //atribute
        int maSach;
        string tenSach;
        string tacGia;
        int namXB;
        Sach[] a;

        //constructor
        public Sach()
        {
            a = null;
        }

        public Sach(int maSach, string tenSach, string tacGia, int namXB)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.namXB = namXB;
        }

        //properties
        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int NamXB { get => namXB; set => namXB = value; }
        internal Sach[] A { get => a; set => a = value; }

        //method
        public void Nhap()
        {
            Console.Write("nhập số quyển sách : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 0)
            {
                Console.Write("nhập lại số quyển sách : ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            a = new Sach[n];
            for (int i = 0; i < n; i++)
            {
                Sach newsach = new Sach();


                int intbook;
                Console.Write("Nhập mã sách : ");
                intbook = Convert.ToInt32(Console.ReadLine());
                while (TonTai(intbook, i))
                {
                    Console.Write("mã sách đã tồn tại, nhập lại  : ");
                    intbook = Convert.ToInt32(Console.ReadLine());
                }
                newsach.MaSach = intbook;

                Console.Write("Nhập tên sách : ");
                newsach.TenSach = Console.ReadLine();

                Console.Write("Nhập tên tác giả : ");
                newsach.TacGia = Console.ReadLine();

                Console.Write("Nhập năm xuất bản : ");
                newsach.NamXB = Convert.ToInt32(Console.ReadLine());




                a[i] = newsach;
            }

        }
        public void Xuat()
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Không có quyển sách nào hết !");
            }
            for (int i = 0; i < a.Length; i++)
            {


                Console.WriteLine("Mã sách = " + a[i].MaSach);
                Console.WriteLine("Tên sách = " + a[i].TenSach);
                Console.WriteLine("Tác giả  = " + a[i].TacGia);
                Console.WriteLine("Năm xuất bản = " + a[i].NamXB);

            }
        }
        private void Xuat2()
        {
            Console.WriteLine("Mã sách = " + this.MaSach);
            Console.WriteLine("Tên sách = " + this.TenSach);
            Console.WriteLine("Tác giả = " + this.TacGia);
            Console.WriteLine("Năm xuất bản = " + this.NamXB);
            Console.WriteLine();
        }

        private void SapXepMang_BubbleSort()
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j].maSach > a[j + 1].maSach)
                    {
                        // Hoán đổi arr[j] và arr[j+1]
                        int temp = a[j].maSach;
                        a[j].maSach = a[j + 1].maSach;
                        a[j + 1].maSach = temp;
                    }
                }
            }
        }
        public void use_QuickSort()
        {
            QuickSort(a, 0, a.Length - 1);
        }
        public void use_MergeSort()
        {
            MergeSort(a, 0, a.Length - 1);
        }
        private void QuickSort(Sach[] a, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(a, low, high);

                QuickSort(a, low, pivotIndex - 1);
                QuickSort(a, pivotIndex + 1, high);
            }
        }

        private int Partition(Sach[] array, int low, int high)
        {
            int pivot = a[high].MaSach;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j].MaSach < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        private void Swap(Sach[] s, int i, int j)
        {
            int temp = s[i].MaSach;
            s[i].MaSach = s[j].MaSach;
            s[j].MaSach = temp;
        }
        private void MergeSort(Sach[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;


                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);


                Merge(array, left, mid, right);
            }
        }

        private void Merge(Sach[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;


            Sach[] leftArray = new Sach[n1];
            Sach[] rightArray = new Sach[n2];


            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = new Sach();
                leftArray[i].MaSach = array[left + i].MaSach;
            }
            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = new Sach();
                rightArray[j].MaSach = array[mid + 1 + j].MaSach;
            }


            int leftIndex = 0, rightIndex = 0;
            int mergedIndex = left;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArray[leftIndex].MaSach <= rightArray[rightIndex].MaSach)
                {
                    array[mergedIndex].MaSach = leftArray[leftIndex].MaSach;
                    leftIndex++;
                }
                else
                {
                    array[mergedIndex].MaSach = rightArray[rightIndex].MaSach;
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < n1)
            {
                array[mergedIndex].MaSach = leftArray[leftIndex].MaSach;
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < n2)
            {
                array[mergedIndex].maSach = rightArray[rightIndex].MaSach;
                rightIndex++;
                mergedIndex++;
            }
        }

        public void TimSachTheoMa()
        {
            Console.Write("Nhập mã sách cần tìm: ");
            int maSachCanTim = int.Parse(Console.ReadLine());

            SapXepMang_BubbleSort();
            // Sử dụng tìm kiếm nhị phân (giả sử mảng đã được sắp xếp)
            int left = 0;
            int right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid].MaSach == maSachCanTim)
                {
                    a[mid].Xuat2();
                    return;
                }
                else if (a[mid].MaSach < maSachCanTim)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine("Không tìm thấy sách có mã sách {0}", maSachCanTim);
        }
        public void InsertBook()
        {

            Sach[] b = new Sach[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = new Sach();  // Initialize the Sach object before copying
                b[i].TacGia = this.a[i].TacGia;
                b[i].MaSach = this.a[i].MaSach;
                b[i].TenSach = this.a[i].TenSach;
                b[i].NamXB = this.a[i].NamXB;
            }

            b[a.Length] = new Sach();

            int intbook;
            Console.Write("Nhập mã sách : ");
            intbook = int.Parse(Console.ReadLine());
            while (TonTai(intbook, b.Length - 1))
            {
                Console.Write("Mã sách đã tồn tại, vui lòng nhập lại  : ");
                intbook = int.Parse(Console.ReadLine());
            }
            b[a.Length].MaSach = intbook;

            Console.Write("Nhập tên sách : ");
            b[a.Length].TenSach = Console.ReadLine();

            Console.Write("Nhập tên tác giả : ");
            b[a.Length].TacGia = Console.ReadLine();

            Console.Write("Nhập năm xuất bản : ");
            b[a.Length].NamXB = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Array.Resize(ref a, a.Length + 1);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Sach();
                a[i].TacGia = b[i].TacGia;
                a[i].MaSach = b[i].MaSach;
                a[i].TenSach = b[i].TenSach;
                a[i].NamXB = b[i].NamXB;

            }

        }
        private bool TonTai(int msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (a[i].MaSach == msx)
                    return true;
            }
            return false;
        }

    }

}
