using System;

    class Staff
    {
        private string _hoTen;
        private string _ngaySinh;
        private double _luong;

        public string HoTen{get => _hoTen; set => _hoTen = value;}
        public string NgaySinh{get => _ngaySinh; set => _ngaySinh = value;}
        public double Luong{get => _luong; set => _luong = value;}


        public Staff()
        {}

        public Staff(string hoTen, string ngaySinh, double luong)
        {
            _hoTen = hoTen;
            _ngaySinh = ngaySinh;
            _luong = luong;
        }

        public Staff(Staff s)
        {
            _hoTen = s._hoTen;
            _ngaySinh = s._ngaySinh;
            _luong = s._luong;
        }
    }
