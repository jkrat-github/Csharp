using System;
using System.Configuration;

namespace DrawPlayButton {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("made by jkrat");
            Console.WriteLine("Type Array Size (9 or more recommended):");
            int size = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[size, size];

            DrawPlayButton(array, size);
        }
        static void DrawPlayButton(string[,] array, int size) {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (j == 1 && i > 1 && i < size-2 || i-1==j/2 && j > 1 && j < size-1 || i+j/2 == size-2 && j > 1 && j < size-1) {
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