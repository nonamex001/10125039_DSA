namespace bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4];
            int[,] matran = a;
            Console.WriteLine("Nhap ma tran 3x4: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu a[{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma tran vua nhap la:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            // a.Tính tổng các phần tử trong ma trận
            Console.WriteLine("tong ma tran:");
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    tong += a[i, j];
                }
            }
            Console.WriteLine("{0}", tong);
            // b.giá trị nhỏ nhất trong ma trận
            Console.WriteLine("giá trị nho nhat:");
            int min = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.WriteLine("{0}", min);
            //c. tổng phần tử trên đường chéo phụ của ma trận
            Console.WriteLine("tong duong cheo phu:");
            int tongCheoPhu = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + j == a.GetLength(1) - 1)
                    {
                        tongCheoPhu += a[i, j];
                    }
                }
            }
            Console.WriteLine("{0}", tongCheoPhu);
        }
    }
}

