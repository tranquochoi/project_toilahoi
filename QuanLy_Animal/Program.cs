using System;

namespace QuanLy_Anime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat c = new Cat();
            c.Input();
            c.Output();
            c.Speak();
            
            Dog d = new Dog();
            d.Input();
            d.Output();
            d.Speak();

        }
    }
}
