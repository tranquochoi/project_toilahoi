using System;

class Program
{
    static void Main(string[] args)
    {
        HinhVe h0 = new HinhVe();
        Console.WriteLine("Dien tich = " + h0.DienTich().ToString());

        HinhVe h1 = new HinhThang();
        Console.WriteLine("=== HINH THANG ===");
        h1.Input();
        Console.WriteLine("Dien Tich Hinh Thang = " + h1.DienTich().ToString());

        HinhVe h2 = new HinhBinhHanh();
        Console.WriteLine("=== HINH BINH HANH ===");
        h2.Input();
        Console.WriteLine("Dien Tich Hinh Binh Hanh: " + h2.DienTich().ToString());

        HinhVe h3 = new HinhChuNhat();
        Console.WriteLine("=== HINH CHU NHAT ===");
        h3.Input();
        Console.WriteLine("Dien Tich Hinh Chu Nhat: " + h3.DienTich().ToString());

        HinhVe h4 = new HinhVuong();
        Console.WriteLine("=== HINH VUONG ===");
        h4.Input();
        Console.WriteLine("Dien Tich Hinh Vuong: " + h4.DienTich().ToString());



        

       
    }
}