using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_02_2024_OnTapOOP
{
    class main
    {
        static void Main()
        {
            int n_Sach, n_TapChi, n_Bao;
            Console.WriteLine("Moi nhap so luong mat hang!!!");
            do
            {
                Console.Write("\nSach(0->10): ");
                n_Sach = Convert.ToInt32(Console.ReadLine());
            } while (n_Sach < 0 || n_Sach > 10);
            Data_Of_Sach[] sach = new Data_Of_Sach[n_Sach];
            Data_Of_Sach sachtemp = new Data_Of_Sach();  //KHONG DUNG METHOD STATIC THI PHAI KHAI 

            do
            {
                Console.Write("\nTapchi(0->10): ");
                n_TapChi = Convert.ToInt32(Console.ReadLine());
            } while (n_TapChi < 0 || n_TapChi > 10);
            Data_Of_TapChi[] tapchi = new Data_Of_TapChi[n_TapChi];
            Data_Of_TapChi tapchitemp = new Data_Of_TapChi();  //KHONG DUNG METHOD STATIC THI PHAI KHAI 

            do
            {
                Console.Write("\nBao(0->10): ");
                n_Bao = Convert.ToInt32(Console.ReadLine());
            } while (n_Bao < 0 || n_Bao > 10);
            Data_Of_Bao[] bao = new Data_Of_Bao[n_Bao];
            Data_Of_Bao baotemp = new Data_Of_Bao();  //KHONG DUNG METHOD STATIC THI PHAI KHAI 

            if (n_Sach != 0)
            {
                for (int i = 0; i < n_Sach; i++)
                {
                    Console.WriteLine($"\nNhap thong tin sach thu {i+1}!!!");
                    #region NHAP GIA TRI TRUC TIEP TRONG CLASS PROGRAM
                    //Console.Write("Nhap ma tai lieu: ");
                    //sach[i].MaTaiLieu = Console.ReadLine();
                    //Console.Write("Nhap ten nha xuat ban: ");
                    //sach[i].TenNhaXuatBan = Console.ReadLine();
                    //Console.Write("Nhap so ban phat hanh: ");
                    //sach[i].SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("Nhap ten tac gia: ");
                    //sach[i].TenTacGia = Console.ReadLine();
                    //Console.Write("Nhap so trang: ");
                    //sach[i].SoTrang = Convert.ToInt32(Console.ReadLine());
                    #endregion

                    //KHONG DUNG METHOD STATIC, nhap gia tri qua method trong class Data_Of_Sach
                    sachtemp.GetInfo_Sach(ref sach[i]);

                    //DUNG METHOD STATIC thi KHOI can khai them sachtemp, dung luon <tenclass>.<ten method tatic>
                    //Data_Of_Sach.GetInfo_Sach(ref sach[i]); 
                }
            }

            if (n_TapChi != 0)
            {
                for (int i = 0; i < n_TapChi; i++)
                {
                    Console.WriteLine($"\nNhap thong tin tap chi thu {i + 1}!!!");
                    #region NHAP GIA TRI TRUC TIEP TRONG CLASS PROGRAM
                    //Console.Write("Nhap ma tai lieu: ");
                    //tapchi[i].MaTaiLieu = Console.ReadLine();
                    //Console.Write("Nhap ten nha xuat ban: ");
                    //tapchi[i].TenNhaXuatBan = Console.ReadLine();
                    //Console.Write("Nhap so ban phat hanh: ");
                    //tapchi[i].SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("Nhap so phat hanh: ");
                    //tapchi[i].SoPhatHanh = Convert.ToInt32(Console.ReadLine()) ;
                    //Console.Write("Nhap thang phat hanh: ");
                    //tapchi[i].ThangPhatHanh = Convert.ToInt32(Console.ReadLine());
                    #endregion

                    //KHONG DUNG METHOD STATIC, nhap gia tri qua method trong class Data_Of_TapChi
                    tapchitemp.GetInfo_TapChi(ref tapchi[i]);

                    //DUNG METHOD STATIC thi KHOI can khai them tapchitemp, dung luon <tenclass>.<ten method tatic>
                    //Data_Of_TapChi.GetInfo_TapChi(ref tapchi[i]);

                }
            }

            if (n_Bao != 0)
            {
                for (int i = 0; i < n_Bao; i++)
                {
                    Console.WriteLine($"\nNhap thong tin bao thu {i + 1}!!!");
                    #region NHAP GIA TRI TRUC TIEP TRONG CLASS PROGRAM
                    Console.Write("Nhap ma tai lieu: ");
                    bao[i].MaTaiLieu = Console.ReadLine();
                    Console.Write("Nhap ten nha xuat ban: ");
                    bao[i].TenNhaXuatBan = Console.ReadLine();
                    Console.Write("Nhap so ban phat hanh: ");
                    bao[i].SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap ngay phat hanh: ");
                    bao[i].NgayPhatHanh = Convert.ToDateTime(Console.ReadLine());
                    #endregion

                    //KHONG DUNG METHOD STATIC, nhap gia tri qua method trong class Data_Of_Bao
                    baotemp.GetInfo_Bao(ref bao[i]);

                    //DUNG METHOD STATIC thi KHOI can khai them baotemp, dung luon <tenclass>.<ten method tatic>
                    //Data_Of_Bao.GetInfo_Bao(ref bao[i]);

                }
            }


            Console.WriteLine("\nCac du lieu vua nhap!!!");

            if (n_Sach == 0) { Console.WriteLine("Khong co sach nao ca!!!"); }
            else
            {
                //KHONG DUNG METHOD STATIC, xuat gia tri qua method trong class Data_Of_Sach
                sachtemp.Xuat_Sach(sach, n_Sach);

                //DUNG METHOD STATIC thi KHOI can khai them sachtemp, dung luon <tenclass>.<ten method tatic>
                //Data_Of_Sach.Xuat_Sach(sach, n_Sach);
            }

            if (n_TapChi == 0) { Console.WriteLine("Khong co tap chi nao ca!!!"); }
            else
            {
                //KHONG DUNG METHOD STATIC, xuat gia tri qua method trong class Data_Of_TapChi
                tapchitemp.Xuat_TapChi(tapchi, n_TapChi);

                //DUNG METHOD STATIC thi KHOI can khai them tapchitemp, dung luon <tenclass>.<ten method tatic>
                //Data_Of_TapChi.Xuat_TapChi(tapchi, n_TapChi);
            }

            if (n_Bao == 0) { Console.WriteLine("Khong co Bao nao ca!!!"); }
            else
            {
                //KHONG DUNG METHOD STATIC, xuat gia tri qua method trong class Data_Of_Bao
                baotemp.Xuat_Bao(bao, n_Bao);

                //DUNG METHOD STATIC thi KHOI can khai them baotemp, dung luon <tenclass>.<ten method tatic>
                //Data_Of_Bao.Xuat_Bao(bao, n_Bao);
            }



            Console.ReadKey();
        }
    }
}
