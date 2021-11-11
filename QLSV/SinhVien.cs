using System.Collections.Generic;
using System;
class SinhVien: Nguoi
{
    string _ma;
    double _dtb;
    
    // Constructor
    public SinhVien(): base()
    {
    }

    public SinhVien(string hoTen, bool gt, string ngaySinh, string ma, double dtb): base(hoTen, gt, ngaySinh)
    {
        _ma = ma;
        _dtb = dtb;
    }

    // Hàm thiết lập sao chép
    public SinhVien(SinhVien sv): base ((Nguoi) sv)
    {
        _ma = sv._ma;
        _dtb = sv._dtb;
    }
    // Phương thức nhập
    public new void Nhap()
    {
        base.Nhap(); // Gọi phương thức nhập của lớp cha
        // Nhập thêm dữ liệu cho lớp con
        Console.Write("Nhap MSSV: ");
        _ma = Console.ReadLine();
        Console.Write("Nhap DTB: ");
        _dtb = double.Parse(Console.ReadLine()); 
    }

    // Phương thức xuất
    public new void Xuat()
    {
        base.Xuat(); // Gọi phương thức xuat của lớp cha
        // In thông tin của lớp con
        Console.WriteLine("MSSV: " + _ma);
        Console.Write("DTB: {0}", _dtb);
     }
}