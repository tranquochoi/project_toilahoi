using System;

class Nguoi
{
    protected string _hoTen;
    bool _gioiTinh;
    string _ngaySinh;
    
    // Hàm nhập
    public void Nhap()
    {
        Console.Write("Ho ten: ");
        _hoTen = Console.ReadLine();
        Console.Write("Gioi tinh : ");
        _gioiTinh = bool.Parse(Console.ReadLine());
    }

    // Hàm xuất
    public void Xuat()
    {
        Console.WriteLine("{0} - {1}", _hoTen, _gioiTinh);
    }

}