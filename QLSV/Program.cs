using System;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng thuộc lớp Người
            /*
            Nguoi n1 = new Nguoi();
            n1.Nhap();
            n1.Xuat();
            */
            // Tạo đối tượng thuộc lớp Sinh viên
            SinhVien sv1 = new SinhVien("Tran Quoc Hoi", false, "20/01/2002", "62130654", 9);
            //sv1.Nhap();
            sv1.Xuat();
            // Tạo đối tượng sv2 sao chép sv1, sử dụng hàm thiết lập sao chép
            SinhVien sv2 = new SinhVien(sv1);
            Console.WriteLine("Thong tin Sinh Vien thu 2: ");
            sv1.Xuat();
        }
    }
}
