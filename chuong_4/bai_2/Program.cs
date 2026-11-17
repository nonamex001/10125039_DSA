using System;

namespace bai_2
{
    internal class Program
    {
        // 1. Lớp Nhân Viên (Sách ghi là struct, nhưng dùng class vẫn chạy đúng nhé)
        class Nhan_Vien
        {
            public string MaNV;
            public string TenNV;
            public int NamSinh;
            public string PhongBan;
            public double LuongCoBan;
            public double Thuong;

            public double ThucLinh()
            {
                return LuongCoBan + Thuong;
            }
        }

        // 2. Lớp Danh Sách Nhân Viên (BỎ kế thừa : Nhan_Vien)
        class DanhSachNhanVien
        {
            public Nhan_Vien[] ds;
            public int n;

            public void Nhap()
            {
                Console.Write("Nhap so luong nhan vien: ");
                n = int.Parse(Console.ReadLine());
                ds = new Nhan_Vien[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("-------------------------------------------");
                    ds[i] = new Nhan_Vien();
                    Console.WriteLine("Nhap thong tin nhan vien thu {0}: ", i + 1);
                    Console.Write("Ma NV: ");
                    ds[i].MaNV = Console.ReadLine();
                    Console.Write("Ten NV: ");
                    ds[i].TenNV = Console.ReadLine();
                    Console.Write("Nam sinh: ");
                    ds[i].NamSinh = int.Parse(Console.ReadLine());
                    Console.Write("Phong ban: ");
                    ds[i].PhongBan = Console.ReadLine();
                    Console.Write("Luong co ban: ");
                    ds[i].LuongCoBan = double.Parse(Console.ReadLine());
                    Console.Write("Thuong: ");
                    ds[i].Thuong = double.Parse(Console.ReadLine());
                }
            }

            public void Xuat()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Ma NV: {0} | Ten NV: {1} | Phong ban: {2}", ds[i].MaNV, ds[i].TenNV, ds[i].PhongBan);
                    Console.WriteLine("Luong CB: {0} | Thuong: {1} | Thuc linh: {2}", ds[i].LuongCoBan, ds[i].Thuong, ds[i].ThucLinh());
                }
                Console.WriteLine("-------------------------------------------");
            }
        }

        // 3. Lớp Chức Năng (BỎ kế thừa : Nhan_Vien)
        class ChucNang
        {
            // Câu a: Tính tổng thực lĩnh
            public void TinhTongThucLinh(DanhSachNhanVien ds)
            {
                double tong = 0;
                for (int i = 0; i < ds.n; i++)
                {
                    tong += ds.ds[i].ThucLinh();
                }
                Console.WriteLine("\n=> TONG THUC LINH CUA CONG TY: {0}", tong);
            }

            // Câu b: In danh sách nhân viên có LƯƠNG CƠ BẢN THẤP NHẤT (Sửa lại cho đúng đề)
            public void InLuongThapNhat(DanhSachNhanVien ds)
            {
                if (ds.n == 0) return;

                // Tìm mức lương thấp nhất
                double minLuong = ds.ds[0].LuongCoBan;
                for (int i = 1; i < ds.n; i++)
                {
                    if (ds.ds[i].LuongCoBan < minLuong)
                        minLuong = ds.ds[i].LuongCoBan;
                }

                // In những người có lương = min
                Console.WriteLine("\n=> NHAN VIEN CO LUONG CO BAN THAP NHAT ({0}):", minLuong);
                for (int i = 0; i < ds.n; i++)
                {
                    if (ds.ds[i].LuongCoBan == minLuong)
                    {
                        Console.WriteLine("- Ma NV: {0} | Ten: {1} | Luong: {2}", ds.ds[i].MaNV, ds.ds[i].TenNV, ds.ds[i].LuongCoBan);
                    }
                }
            }

            // Câu c: Đếm số lượng nhân viên có mức thưởng >= 1200000
            public void DemThuongCao(DanhSachNhanVien ds)
            {
                int dem = 0;
                for (int i = 0; i < ds.n; i++)
                {
                    if (ds.ds[i].Thuong >= 1200000)
                        dem++;
                }
                Console.WriteLine("\n=> SO NHAN VIEN CO THUONG >= 1.200.000 LA: {0}", dem);
            }

            // Câu d: Sắp xếp tăng dần theo phòng ban, nếu trùng thì giảm dần theo mã NV
            public void SapXepPhongBanTang_MaNVGiam(DanhSachNhanVien ds)
            {
                for (int i = 0; i < ds.n - 1; i++)
                {
                    for (int j = i + 1; j < ds.n; j++)
                    {
                        bool canDoiCho = false;
                        int soSanhPhongBan = string.Compare(ds.ds[i].PhongBan, ds.ds[j].PhongBan);

                        if (soSanhPhongBan > 0) // Phòng ban i > j -> Đổi để tăng dần
                        {
                            canDoiCho = true;
                        }
                        else if (soSanhPhongBan == 0) // Trùng phòng ban
                        {
                            // Mã NV i < j -> Đổi để giảm dần
                            if (string.Compare(ds.ds[i].MaNV, ds.ds[j].MaNV) < 0)
                            {
                                canDoiCho = true;
                            }
                        }

                        if (canDoiCho)
                        {
                            Nhan_Vien temp = ds.ds[i];
                            ds.ds[i] = ds.ds[j];
                            ds.ds[j] = temp;
                        }
                    }
                }
                Console.WriteLine("\n=> DA SAP XEP THEO PHONG BAN TANG DAN, MA NV GIAM DAN.");
                ds.Xuat(); // In lại danh sách sau khi xếp
            }

            // Câu e: Tăng lương cơ bản lên 5%
            public void TangLuong5PhanTram(DanhSachNhanVien ds)
            {
                for (int i = 0; i < ds.n; i++)
                {
                    ds.ds[i].LuongCoBan = ds.ds[i].LuongCoBan * 1.05;
                }
                Console.WriteLine("\n=> DA TANG LUONG CO BAN CUA TAT CA NHAN VIEN LEN 5%.");
                ds.Xuat(); // In lại danh sách để thấy sự thay đổi
            }
        }

        // 4. Hàm Main để test các chức năng
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.Nhap();

            ChucNang cn = new ChucNang();

            // Gọi lần lượt các hàm ra để chạy
            cn.TinhTongThucLinh(ds);
            cn.InLuongThapNhat(ds);
            cn.DemThuongCao(ds);
            cn.SapXepPhongBanTang_MaNVGiam(ds);
            cn.TangLuong5PhanTram(ds);

            Console.ReadLine();
        }
    }
}