using System;

namespace Array
{
    class IP_Array
    {

        static void Nhap(int []a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Xuat(int[]a, int n)
        {   
            Console.Write("So mang vua nhap: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[]a = new int [100];
            Nhap(a, n);
            Xuat(a, n);
        }
    }
} 
