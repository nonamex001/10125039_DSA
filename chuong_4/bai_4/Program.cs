using System;
namespace bai_4
{
    

    class Program
    {
        class Node
        {
            public int Data;
            public Node Next;
            public Node(int value) { Data = value; Next = null; }
        }

        // Hàm in danh sách
        static void InDanhSach(Node pHead)
        {
            Node p = pHead;
            while (p != null)
            {
                Console.Write(p.Data + " -> ");
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        // --- CÁC HÀM GIẢI BÀI TẬP ---
        static int TimMax(Node pHead) { /* Code ở trên */ return 0; }
        static int DemSoLanXuatHien(Node pHead, int x) { /* Code ở trên */ return 0; }
        static Node XoaPhanTuX(Node pHead, int x) { /* Code ở trên */ return pHead; }

        static void Main()
        {
            // Tạo danh sách: 5 -> 2 -> 8 -> 5 -> 1 -> 5
            Node pHead = new Node(5);
            pHead.Next = new Node(2);
            pHead.Next.Next = new Node(8);
            pHead.Next.Next.Next = new Node(5);
            pHead.Next.Next.Next.Next = new Node(1);
            pHead.Next.Next.Next.Next.Next = new Node(5);

            Console.Write("Danh sach ban dau: ");
            InDanhSach(pHead);

            // Câu a
            Console.WriteLine("Phan tu lon nhat: " + TimMax(pHead));

            // Câu b
            Console.Write("Nhap x de dem: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("So lan xuat hien cua {0} la: {1}", x, DemSoLanXuatHien(pHead, x));

            // Câu c
            Console.WriteLine("Tien hanh xoa phan tu {0}...", x);
            pHead = XoaPhanTuX(pHead, x);

            Console.Write("Danh sach sau khi xoa: ");
            InDanhSach(pHead);

            Console.ReadLine();
        }
    }
}
