using System;
    public class Animal
    {
        protected double _height;
        double _weight;
        string _color;
        bool _sex;

        public Animal()
        {

        }

        public virtual void Speak()
        {

        }

        public void Input()
        {
            Console.Write("Height: " );
            _height = double.Parse(Console.ReadLine());
            Console.Write("Weight: " );
            _weight = double.Parse(Console.ReadLine());
            Console.Write("Color: " );
            _color = (Console.ReadLine());
            Console.Write("Sex: " );
            _sex = bool.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Information just entered: {0} cm - {1} kg - {2} - {3}", _height, _weight, _color, _sex);
        }
    }