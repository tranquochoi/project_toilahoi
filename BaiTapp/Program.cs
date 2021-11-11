using System;

namespace Bai2_1
{
    //Khai báo lớp Phân số
    public class PhanSo
    {
        private int _tuSo;
        private int _mauSo;
        
        public int MauSo
        {
            get{return _mauSo;}
            set{_mauSo = value;}
        }
        
        public int TuSo
        {
            get{return _tuSo;}
            set{_tuSo = value;}
        }
        
        public PhanSo(int t = 0, int m = 1)
        {
            if(m == 0)
                throw new ArgumentException("Mau so phai khac 0", nameof(m));
                TuSo = t;
                MauSo = m;
        }
        
        public void Nhap()
        {
            Console.WriteLine("Nhap Tu So: ");
            TuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhap Mau So: ");
                MauSo = int.Parse(Console.ReadLine());
                if(MauSo == 0) Console.WriteLine("Yeu Cau: Mau So != 0");
            }while(MauSo == 0);
        }
        
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", TuSo, MauSo);
        }
        
        public void ToiGian()
        {
            int ucln = 1;
            for (int i = Math.Min(Math.Abs(TuSo), Math.Abs(MauSo)); i > 1; i--)
                if (MauSo % i == 0 && TuSo % i == 0)
                {
                    ucln = i;
                    break;
                }
            TuSo /= ucln;
            MauSo /= ucln;
        }
        
        public void Cong(PhanSo p)
        {
            _tuSo = _tuSo * p._mauSo + _mauSo * p._tuSo;
            _mauSo = _mauSo * p._mauSo;
        }
        
        public void Tru(PhanSo p)
        {
            _tuSo = (_tuSo * p._mauSo) - (_mauSo * p._tuSo);
            _mauSo = _mauSo * p._mauSo;
        }
    
    
    } // End of class PhanSo
    
    
    // Main program 
    class Program
    {
        static void Main()
        {
            PhanSo p1 = new PhanSo(4,2);
            Console.Write("result: ");
            p1.Xuat();
            p1.ToiGian();
            p1.Xuat();
            
            PhanSo p2 = new PhanSo();
            p2.Nhap();
            p2.Xuat();
            
            Console.Write("Cong Phan So: ");
            p1.Cong(p2);
            p1.Xuat();
            
            PhanSo p3 = new PhanSo();
            p3.Nhap();
            p3.Xuat();
            
            PhanSo p4 = new PhanSo();
            p4.Nhap();
            p4.Xuat();
            
            Console.Write("Tru Phan So: ");
            p3.Tru(p4);
            p3.Xuat();
        }
    } // End of class Program
}

