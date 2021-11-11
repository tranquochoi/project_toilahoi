using System;

    class Officer: Staff
    {
        int _soNgayLamViec;

        public Officer(): base()
        {}

        public int soNgayLamViec
        {
            get{return _soNgayLamViec;}
            set{_soNgayLamViec = value;}
        }

        public Officer(string hoTen, string ngaySinh, double luong, int soNgayLamViec): base(hoTen, ngaySinh, luong)
        {
            _soNgayLamViec = soNgayLamViec;
        }

        public Officer(Officer o):base((Officer)o)
        {
            _soNgayLamViec = o._soNgayLamViec;
        }

        
        public double TinhLuong(int _soNgayLamViec)
        {
            double TinhLuong;
            TinhLuong = (_soNgayLamViec * 100.000);
            return TinhLuong;
        }


    }
