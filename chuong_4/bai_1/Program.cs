namespace chuong_4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int[] a = new int[5];
            Console.WriteLine("Nhap 5 so nguyen: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap so thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var m in a)
            {
                Console.Write(m + " ");
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                tmp[i] = a[i];
            }
            Console.WriteLine("\nMang tmp : ");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }
            int k = 0;
            Console.WriteLine("\nNhap vị trí can chen: ");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == k)
                {
                    Console.WriteLine("Nhap gia tri can chen: ");
                    tmp[i] = int.Parse(Console.ReadLine());
                }
                else if (i > k)
                {
                    tmp[i] = a[i - 1];
                }
            }
            Console.WriteLine("\nMang sau khi chen: ");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }
          
            */






            int[] a = new int[5];
            Console.WriteLine("Nhap 5 so nguyen: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap so thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            // In mảng a ban đầu
            Console.Write("\nMang a ban dau: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            // --- BẮT ĐẦU PHẦN CHÈN ---
            int k;
            // Kiểm tra vị trí chèn k phải từ 0 đến a.Length (chèn ở cuối)
            do
            {
                Console.Write("\n\nNhap vi tri can chen (tu 0 den {0}): ", a.Length);
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k > a.Length);

            Console.Write("Nhap gia tri can chen x: ");
            int x = int.Parse(Console.ReadLine());

            // 1. Tạo mảng tmp lớn hơn 1 phần tử
            int[] tmp = new int[a.Length + 1];

            // 2. Copy các phần tử bên trái vị trí chèn (từ 0 đến k-1)
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }

            // 3. Chèn x vào vị trí k
            tmp[k] = x;

            // 4. Copy các phần tử bên phải vị trí chèn (từ k đến cuối a), đẩy lùi lại 1 vị trí (i + 1)
            for (int i = k; i < a.Length; i++)
            {
                tmp[i + 1] = a[i];
            }

            // --- IN KẾT QUẢ ---
            Console.Write("\nMang sau khi chen: ");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }

            Console.WriteLine(); // Xuống dòng cho đẹp
        }
    }
}





