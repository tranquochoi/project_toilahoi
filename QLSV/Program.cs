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
            SinhVien sv1 = new SinhVien();
            sv1.Nhap();
            sv1.Xuat();
        }
    }
}
