using System;

    class  Xe
    {
        public string BienSo;
        public int NamSX;
        public double GiaTien;   

        public Xe()
        {
        }

        public Xe(string bienSo=" ", int namSX=0, double giaTien=0)
        {
            BienSo = bienSo;
            NamSX = namSX;
            GiaTien = giaTien;
        }

        public virtual void Input()
        {
            Console.Write("Nhap bien so:");
            BienSo = Console.ReadLine();
            Console.Write("Nhap nam san xuat: ");
            NamSX = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tien: ");
            GiaTien = double.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Bien So: {0}\tNam san xuat: {1}\tGia tien: {2}", BienSo, NamSX, GiaTien);
        }

        public double ToDouble()
        {
            return GiaTien;
        }

        public int ToInt32()
        {
            return NamSX;
        }


    }
