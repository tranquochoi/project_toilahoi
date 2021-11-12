using System;

class Nguoi
{
    protected string _hoTen;
    bool _gioiTinh;
    string _ngaySinh;
    
    // Constructor
    public Nguoi()
    {

    }

    public Nguoi(string hoTen=" ", bool gt=false, string ngaySinh=" ")
    {
        _hoTen = hoTen;
        _gioiTinh = gt;
        _ngaySinh = ngaySinh;
    }

    // coppy constructor
     public Nguoi(Nguoi ng)
    {
        _hoTen = ng._hoTen;
        _gioiTinh = ng._gioiTinh;
        _ngaySinh = ng._ngaySinh;
    }
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
        Console.WriteLine("{0} - {1} - {2}", _hoTen, _ngaySinh ,_gioiTinh);
    }

}