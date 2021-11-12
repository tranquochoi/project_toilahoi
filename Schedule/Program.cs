using System;

namespace Schedule
{
    class NumberOfLessons
    {
        public static string Info;
        static NumberOfLessons()
        {
            DateTime now = DateTime.Now;

            switch(now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                Info = "7h: OOP (3 tiet) - 15h50p: Nhap Mon Quan Tri Hoc (2 tiet)";
                break;
                case DayOfWeek.Saturday:
                Info = "7h: Chu Nghia Xa Hoi Khoa Hoc (2 tiet) - 8h50p: He Dieu Hanh (3 tiet)";
                break;
                case DayOfWeek.Sunday:
                Info = "7h: Cau Truc Du Lieu Va Giai Thuat (3 tiet) - 9h50p: Ky Thuat Soan Thao Van Ban (2 tiet)";
                break;
                case DayOfWeek.Thursday:
                Info = "7h: Phuong Phap Nghien Cuu Khoa Hoc (2 tiet) - 8h50p: Xac Suat Thong Ke (3 tiet)";
                break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thong tin tiet hoc ngay hom nay: " + NumberOfLessons.Info);
        }
    }
}
