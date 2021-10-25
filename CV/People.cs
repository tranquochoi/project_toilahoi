using System;

namespace CV
{
    class People
    {
        private string _name;
        private int _age;
        private string _address;
        private string _sex;
        private double _height;
        private double _weight;
        private string _haircolor;

        public void Input()
        {
            Console.Write("Name: ");
            _name = (Console.ReadLine());
            Console.Write("Age: ");
            _age = int.Parse(Console.ReadLine());
            Console.Write("Address: ");
            _address = (Console.ReadLine());
            Console.Write("Sex: ");
            _sex = (Console.ReadLine());
            Console.Write("Height: ");
            _height = double.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            _weight = double.Parse(Console.ReadLine());
            Console.Write("Hair Color: ");
            _haircolor = (Console.ReadLine());

        }

        public void Output()
        {
            Console.Write("Name: {0} - Age: {1} - Address: {2} - Sex: {3}", _name, _age, _address, _sex);
            Console.WriteLine(" - Height: {0} cm - Weight: {1} kg - Hair Color: {2}.", _height, _weight, _haircolor);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            People Mem_1 = new People();
            Console.WriteLine("-Member 1-");
            Mem_1.Input();
            Mem_1.Output();

            People Mem_2 = new People();
            Console.WriteLine("-Member 2-");
            Mem_2.Input();
            Mem_2.Output();
            
        }
    }
}