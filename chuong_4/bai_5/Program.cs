
using System;
namespace bai_5
{

    class Program
    {
        class Node
        {
            public int Data;
            public Node Next;
            public Node(int value) { Data = value; Next = null; }
        }

        // Hàm tìm Max
        static int TimMax(Node pHead)
        {
            if (pHead == null) return 0;

            int max = pHead.Data;
            Node p = pHead.Next;
            while (p != null)
            {
                if (p.Data > max) max = p.Data;
                p = p.Next;
            }
            return max;
        }

        static void Main()
        {
            // Tạo danh sách liên kết: 15 -> 8 -> 25 -> 10
            Node pHead = new Node(15);
            pHead.Next = new Node(8);
            pHead.Next.Next = new Node(25);
            pHead.Next.Next.Next = new Node(10);

            Console.WriteLine("Danh sach hien tai: 15 -> 8 -> 25 -> 10");

            // Gọi hàm tìm Max
            int maxValue = TimMax(pHead);
            Console.WriteLine("Phan tu lon nhat trong danh sach la: " + maxValue);

            Console.ReadLine();
        }
    }
}

