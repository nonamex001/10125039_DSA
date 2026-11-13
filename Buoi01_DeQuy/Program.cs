using System;
using System.Globalization;
using System.Text;

class Program
{



    static long S1(int n)
    {
        if (n == 1) return 1;              
        return S1(n - 1) + n;              
    }

   
    static long S2(int n)
    {
        if (n == 1) return 1;
        return S2(n - 1) + (long)n * n;
    }

  
    static double S3(int n)
    {
        if (n == 1) return 1;
        return S3(n - 1) + 1.0 / n;
    }


    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static double S4(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n);
    }

 
    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

   
    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

   
    static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }

    
    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double S8(int n)
    {
        return Can(1, n);
    }

   

    static void bai3_1(int n)
    {
        Console.WriteLine($"S({n}) = 1 + 2 + ... + {n} = {S1(n)}");
    }

    static void bai3_2(int n)
    {
        Console.WriteLine($"S({n}) = 1 + 2^2 + ... + {n}^2 = {S2(n)}");
    }

    static void bai3_3(int n)
    {
        Console.WriteLine($"S({n}) = 1 + 1/2 + ... + 1/{n} = {S3(n):F4}");
    }

    static void bai3_4(double x, int n)
    {
        Console.WriteLine($"S({x}, {n}) = {x}^{n} = {S4(x, n)}");
    }

    static void bai3_5(int n)
    {
        Console.WriteLine($"Ước lẻ lớn nhất của {n} là {UocLeMax(n)}");
    }

    static void bai3_6(int a, int b)
    {
        Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
    }

    static void bai3_7(int n)
    {
        Console.WriteLine($"Số {n} có {SoChuSo(n)} chữ số");
    }

    static void bai3_8(int n)
    {
        Console.WriteLine($"S({n}) = sqrt(1 + sqrt(2 + ... + sqrt({n}))) = {S8(n):F6}");
    }



    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;                       
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;    

        Console.WriteLine("=== Bài 3.1: Tính S(n) = 1 + 2 + 3 + ... + n ===");
        bai3_1(5);
        bai3_1(10);

        Console.WriteLine("=== Bài 3.2: Tính S(n) = 1 + 2^2 + 3^2 + ... + n^2 ===");
        bai3_2(3);
        bai3_2(10);

        Console.WriteLine("=== Bài 3.3: Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/n ===");
        bai3_3(4);
        bai3_3(10);

        Console.WriteLine("=== Bài 3.4: Tính S(x, n) = x^n ===");
        bai3_4(2, 10);
        bai3_4(5, 0);
        bai3_4(2, -3);

        Console.WriteLine("=== Bài 3.5: Tìm ước lẻ lớn nhất của n ===");
        bai3_5(100);
        bai3_5(48);
        bai3_5(7);

        Console.WriteLine("=== Bài 3.6: Tìm ước chung lớn nhất của a, b ===");
        bai3_6(48, 18);
        bai3_6(17, 5);

        Console.WriteLine("=== Bài 3.7: Đếm số chữ số của n ===");
        bai3_7(7);
        bai3_7(12345);

        Console.WriteLine("=== Bài 3.8: Tính S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n))) ===");
        bai3_8(3);
        bai3_8(5);
        bai3_8(10);
    }
}
