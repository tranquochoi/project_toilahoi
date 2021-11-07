using System.Runtime.InteropServices;
using System;

    class Dog: Animal
    {
        string _name;
        int _cute;

        public Dog(): base()
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Gau Gau Gau");
        }

        /*public Dog(double _height, double _weight, string _color, bool _sex, string _name, int _cute): base()
        {

        }*/

        public new void Input()
        {
            base.Input();
            Console.Write("Name: ");
            _name = Console.ReadLine();
            Console.Write("Cute: ");
            _cute = int.Parse(Console.ReadLine());
        }

        public new void Output()
        {
            base.Output();
            Console.WriteLine("{0} - {1} %", _name, _cute);
        }

    }

