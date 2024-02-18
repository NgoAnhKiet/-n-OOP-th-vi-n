using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_02_2024_OnTapOOP
{
    
    class Data_Chung
        {
            protected string matailieu = "";
            protected string tennhaxuatban = "";
            protected int sobanphathanh = 0;
        
            
            public string MaTaiLieu
            {
                get => matailieu;
                set => matailieu = value;
            }
            public string TenNhaXuatBan
            {
                get => tennhaxuatban;
                set => tennhaxuatban = value;
            }
            public int SoBanPhatHanh
            {
                get => sobanphathanh;
                set => sobanphathanh = value;
            }
        }

    class Data_Of_Sach : Data_Chung
    {
            private string tentacgia;
            private int sotrang;
            public string TenTacGia
            {
                get => tentacgia;
                set => tentacgia = value;
            }

            public int SoTrang
            {
                get => sotrang;
                set => sotrang = value;
            }
        //KHONG DUNG METHOD SATIC(Ham tinh)
        public void GetInfo_Sach(ref Data_Of_Sach sach)
        {
            Console.Write("Nhap ma tai lieu: ");
            sach.MaTaiLieu = Console.ReadLine();
            Console.Write("Nhap ten nha xuat ban: ");
            sach.TenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            sach.SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten tac gia: ");
            sach.TenTacGia = Console.ReadLine();
            Console.Write("Nhap so trang: ");
            sach.SoTrang = Convert.ToInt32(Console.ReadLine());
        }
        //DUNG METHOD STATIC(Ham tinh)
        //public STATIC void GetInfo_Sach(ref Data_Of_Sach sach)

        //KHONG DUNG METHOD SATIC(Ham tinh)
        public void Xuat_Sach(Data_Of_Sach[] sach, int n_sach)
        {
            for (int i = 0; i < n_sach; i++)
            {
                Console.WriteLine($"\nSach thu {i + 1} ");
                Console.WriteLine($"Ma tai lieu: {sach[i].MaTaiLieu}");
                Console.WriteLine($"Ten nha xuat ban: {sach[i].TenNhaXuatBan}");
                Console.WriteLine($"So ban phat hanh: {sach[i].SoBanPhatHanh}");
                Console.WriteLine($"Ten tac gia: {sach[i].TenTacGia}");
                Console.WriteLine($"So trang: {sach[i].SoTrang}");
            }
        }
        //DUNG METHOD STATIC(Ham tinh)
        //public STATIC void Xuat_Sach(Data_Of_Sach[] sach, int n_sach)

    }

    class Data_Of_TapChi : Data_Chung
    {
            private int sophathanh;
            private int thangphathanh;
            public int SoPhatHanh
            {
                get => sophathanh;
                set => sophathanh = value;
            }
            public int ThangPhatHanh
            {
                get => thangphathanh;
                set => thangphathanh = value;
            }
        //KHONG DUNG METHOD SATIC(Ham tinh)
        public void GetInfo_TapChi(ref Data_Of_TapChi tapchi)
        {
            Console.Write("Nhap ma tai lieu: ");
            tapchi.MaTaiLieu = Console.ReadLine();
            Console.Write("Nhap ten nha xuat ban: ");
            tapchi.TenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            tapchi.SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so phat hanh: ");
            tapchi.SoPhatHanh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thang phat hanh: ");
            tapchi.ThangPhatHanh = Convert.ToInt32(Console.ReadLine());


        }
        //DUNG METHOD STATIC(Ham tinh)
        //public STATIC void GetInfo_TapChi(ref Data_Of_TapChi tapchi)

        //KHONG DUNG METHOD SATIC(Ham tinh)
        public void Xuat_TapChi(Data_Of_TapChi[] tapchi, int n_tapchi)
        {
            for (int i = 0; i < n_tapchi; i++)
            {
                Console.WriteLine($"\nTap chi thu {i + 1} ");
                Console.WriteLine($"Ma tai lieu: {tapchi[i].MaTaiLieu}");
                Console.WriteLine($"Ten nha xuat ban: {tapchi[i].TenNhaXuatBan}");
                Console.WriteLine($"So ban phat hanh: {tapchi[i].SoBanPhatHanh}");
                Console.WriteLine($"So phat hanh: {tapchi[i].SoPhatHanh}");
                Console.WriteLine($"Thang phat hanh: {tapchi[i].ThangPhatHanh}");
            }
        }
        //DUNG METHOD STATIC(Ham tinh)
        //public STATIC void Xuat_TapChi(Data_Of_TapChi[] tapchi, int n_tapchi)
    }

    class Data_Of_Bao : Data_Chung
    {
            private DateTime ngayphathanh;
            public DateTime NgayPhatHanh
            {
                get => ngayphathanh;
                set => ngayphathanh = value;
            }
        //KHONG DUNG METHOD SATIC(Ham tinh)
        public void GetInfo_Bao(ref Data_Of_Bao bao)
        {
            Console.Write("Nhap ma tai lieu: ");
            bao.MaTaiLieu = Console.ReadLine();
            Console.Write("Nhap ten nha xuat ban: ");
            bao.TenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            bao.SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ngay phat hanh: ");
            bao.NgayPhatHanh = Convert.ToDateTime(Console.ReadLine());

        }
        //DUNG METHOD STATIC(Ham tinh)
        //public STATIC void GetInfo_Bao(ref Data_Of_Bao bao)

        //KHONG DUNG METHOD SATIC(Ham tinh)
        public void Xuat_Bao(Data_Of_Bao[] bao, int n_bao)
        {
            for (int i = 0; i < n_bao; i++)
            {
                Console.WriteLine($"\nBao thu {i + 1} ");
                Console.WriteLine($"Ma tai lieu: {bao[i].MaTaiLieu}");
                Console.WriteLine($"Ten nha xuat ban: {bao[i].TenNhaXuatBan}");
                Console.WriteLine($"So ban phat hanh: {bao[i].SoBanPhatHanh}");
                Console.WriteLine($"Ngay phat hanh: {bao[i].NgayPhatHanh}");

            }
        }
        //DUNG METHOD STATIC(Ham tinh)
        //public STATIC void Xuat_Bao(Data_Of_Bao[] bao, int n_bao)
    }

    


}
