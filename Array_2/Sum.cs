using System;

namespace Array_2
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.Write(" Moi ban nhap so dong cua mang: ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write(" Moi ban nhap so cot cua mang: ");
            int Columns = int.Parse(Console.ReadLine());

            int[,] IntArray = new int[Rows, Columns];
             
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntArray[{0}, {1}] = ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int Sum = 0;

            Console.WriteLine("\n Mang ban vua nhap la: ");
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(IntArray[i, j] + " ");
                    Sum +=  IntArray[i, j];
                }
                
                Console.WriteLine();
            }
            Console.WriteLine(" Tong cac gia tri trong mang: " + Sum);
        }
    }
}
