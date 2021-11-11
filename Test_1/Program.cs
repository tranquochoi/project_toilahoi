using System;

namespace Test_1
{
    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            DateTime now = DateTime.Now;

            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* In ra màn hình giá trị của thuộc tính màu chủ đạo */
            Console.WriteLine(" Mau chu dao cua hom nay: " + MauSac.MauChuDao);
        }
    }
}
