using System;

    class Production: Staff
    {
        private double _luongCanBan;
        private int _soSanPham;

        public double luongCanBan
        {
            get => _luongCanBan;
            set => _luongCanBan = value;
        }

        public int soSanPham
        {
            get => _soSanPham;
            set => _soSanPham = value;
        }

        public Production(): base()
        {}

        public Production(string hoTen, string ngaySinh, double luong, double luongCanBan, int soSanPham): base(hoTen, ngaySinh, luong)
        {
            _luongCanBan = luongCanBan;
            _soSanPham = soSanPham;
        }

        public Production(Production ps):base((Production) ps)
        {
            _luongCanBan = ps._luongCanBan;
            _soSanPham = ps._soSanPham;
        }

        public void Input()
        {
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            NgaySinh = (Console.ReadLine());
            Console.Write("Nhap luong can ban: ");
            _luongCanBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap so san pham: ");
            _soSanPham = int.Parse(Console.ReadLine());
        }

        public void Display()
        {   
            Console.WriteLine(" ========== ");
            Console.WriteLine("Danh sach nhan vien");
            Console.WriteLine("Ho ten: {0} - Ngay sinh: {1} - Luong can ban: {2} - So san pham: {3} - Tien luong: {4:F3}", HoTen, NgaySinh, _luongCanBan, _soSanPham, Luong);
            Console.WriteLine(" ========== ");

        }

        public new double Luong
        {
            get => Convert.ToDouble((_luongCanBan + _soSanPham)*5.000);
        }



    
    }

