
using System;

    class XeCon: Xe
    {
        
        private int _soChoNgoi;
        private string _loaiXe;

        public int SoChoNgoi{get=>_soChoNgoi; set=>_soChoNgoi=value;}
        public string LoaiXe{get=>_loaiXe; set=>_loaiXe=value;}
 
        public XeCon(): base()
        {}

        public XeCon(string bienSo, int namSX, double giaTien, int soChoNgoi, string loaiXe):base(bienSo, namSX, giaTien)
        {
            _loaiXe = loaiXe;
            _soChoNgoi = soChoNgoi;
        }

        public XeCon(XeCon xc):base((XeCon) xc)
        {
            _loaiXe = xc._loaiXe;
            _soChoNgoi = xc._soChoNgoi;
        }

        public new void Input()
        {
            base.Input();
            Console.Write("So cho ngoi: ");
            _soChoNgoi =  int.Parse(Console.ReadLine());
            Console.Write("Loai xe: ");
            _loaiXe = Console.ReadLine();
        }


    }
