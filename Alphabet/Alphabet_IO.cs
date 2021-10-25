using System;

namespace Alphabet
{
    class Alphabet_IO
    {
        static void Main(string[] args)
        {
            string[,] ArrayString = {
                                {"A", "B", "C", "D", "E", "F", "G"},
                                {"a", "b", "c", "d", "e", "f", "g"},
                                {"H", "I", "J", "K", "L", "M", "N"},
                                {"h", "i", "j", "k", "l", "m", "n"},
                                {"O", "P", "Q", "R", "S", "T", "U"},
                                {"o", "p", "q", "r", "s", "t", "u"},
                                {"V", "W", "X", "Y", "Z", ",", "."},
                                {"v", "w", "x", "y", "z", ";", ":"}
                                    };
        
            Console.Write(ArrayString[2, 0] + ArrayString[1, 4] + ArrayString[3, 4] + ArrayString[3, 4] + ArrayString[5, 0]);
            Console.Write(" ");
            Console.Write(ArrayString[2, 0] + ArrayString[5, 0] + ArrayString[3, 1]);
            Console.Write(", ");
            Console.Write(ArrayString[2, 5] + ArrayString[7, 3]);
            Console.Write(" ");
            Console.Write(ArrayString[3, 6]+ ArrayString[1, 0] + ArrayString[3, 5] + ArrayString[1, 4]);
            Console.Write(" ");
            Console.Write(ArrayString[3, 1] + ArrayString[5, 4]);
            Console.Write(" ");
            Console.Write(ArrayString[6, 1] + ArrayString[3, 1] + ArrayString[3, 6] + ArrayString[1, 3] + ArrayString[5, 0] + ArrayString[7, 1] + ArrayString[5, 4]);            
            
        }
    }
}
