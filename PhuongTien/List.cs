using System;
class List
{
    private XeCon[] _lXC;
    private int _n;

    public XeCon[] LXC{get => _lXC;}

    public void XC_List()
    {
        Console.Write("So luong xe: ");
        _n = Convert.ToInt32(Console.ReadLine());
        XeCon[] xc = new XeCon[_n];

        for(int i=0; i<_n; i++)
        {
            Console.WriteLine("Nhap xe con thu " +(i+1));
            Console.WriteLine(" ========== ");
            xc[i] = new XeCon();
            xc[i].Input();
            xc[i].Display();
        }

        XeCon max = new XeCon();
        XeCon min = new XeCon();

        min = xc[0];
        max = xc[0];

        for(int i=1;i<_n;i++)
        {
            if(max.GiaTien < xc[i].GiaTien)
                max = xc[i];
            if(min.GiaTien > xc[i].GiaTien)
                min = xc[i];
        }
        Console.WriteLine(" ========== ");
        Console.WriteLine("\txe co gia cao nhat la: {0}", max.GiaTien);
        Console.WriteLine("\txe co gia tien thap nhat la: {0}", min.GiaTien);

        Console.WriteLine(" ========== ");
        Console.WriteLine("Nhap vao 2 so dau cua bien so xe: ");
        string soDau = Console.ReadLine();

        for(int i=0; i<_n;i++)
        {
            if(xc[i].BienSo.StartsWith(soDau) == true)
            xc[i].Display();
            Console.Write("\n");
        }

        Console.WriteLine(" ==========");
        XeCon nxs = new XeCon();
        for(int i=0; i<_n-1;i++)
        {
            for(int j=i+1; j<_n; j++)
            {
                if (xc[i].NamSX > xc[j].NamSX)
                {
                    nxs = xc[i];
                    xc[i] = xc[j];
                    xc[j] = nxs;
                }
            }
        }
        Console.WriteLine(" ========== ");
        Console.WriteLine("--- Danh sach xe sau khi sap xep ---");
        for(int i=0; i<_n; i++)
        {
            xc[i].Display();
            Console.Write("\n");
        }
    
    }
}