using System;

    class Cat: Animal
    {
        string _name;
        int _cute;

        public Cat(): base()
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Mewo Mewo Mewo");
        }

        //public Cat(double _height, double _weight, string _color, bool _sex, string _name, int _cute):

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
