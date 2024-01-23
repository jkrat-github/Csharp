using System;
using System.Configuration;

namespace DrawStar {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("made by jkrat");
            Console.WriteLine("Type Array Size (11 or more recommended):");
            int size = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[size, size];

            DrawStar(array, size);
        }
        static void DrawStar(string[,] array, int size) {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (i/2 == j-size/2 || i/2+j == size/2 || i == size/2
                        || i-1-size/2 == j/2 || i+j/2-size/2 == size-size/2-1) {
                        Console.Write(array[i, j] + "*");
                    }
                    else {
                        Console.Write(array[i, j] + ".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
