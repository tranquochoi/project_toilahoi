/*
Một loại vi trùng cứ sau mỗi giờ lại nhân đôi. Hỏi ban đầu có n con vi trùng thì sau h giờ số lượng là bao nhiêu?

Input:
- Số lượng vi trùng ban đầu (con)
- Khoảng thời gian (giờ).

Output: Số lượng vi trùng sau khoảng thời gian đã cho.
*/

using System;

namespace ViTrung
{
    class SoLuongViTrung
    {
        static void Main(string[] args)
        {
            int n, h;
            double result = 1;
            
            Console.Write("Nhap so luong vi trung ban dau: ");
            n = int.Parse(Console.ReadLine());
            
            Console.Write("Nhap khoang thoi gian: ");
            h = int.Parse(Console.ReadLine());
            
            result = n;
            for(int i = 1; i <= h; i++)
            {
                result *= 2;
            }
            Console.WriteLine("Sau khoang thoi gian {0} (gio), so luong vi trung la: {1} con", h, result);            
        }
            
    }
}

