
using System;

    class XeCon: Xe
    {
        public string LoaiXe{get;set;}
        public int SoChoNgoi{get;set;}

        public XeCon(): base()
        {}

        public XeCon(string bienSo, int namSX, double giaTien, int soChoNgoi, string loaiXe):base(bienSo, namSX, giaTien)
        {
            LoaiXe = loaiXe;
            SoChoNgoi = soChoNgoi;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai xe: ");
            LoaiXe = Console.ReadLine();
            Console.Write("Nhap so cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());

        }

        public override void Display()
        {  
            Console.WriteLine(" ========== ");
            Console.WriteLine("Thong tin xe con: ");
            Console.WriteLine("Loai xe: {0}\tSo cho ngoi: {1}",LoaiXe, SoChoNgoi);
            base.Display();
        }

        public double giaTien
        {
            get => Convert.ToDouble(GiaTien);
        }

        public int namSX
        {
            get => Convert.ToInt32(NamSX);
        }
    }
