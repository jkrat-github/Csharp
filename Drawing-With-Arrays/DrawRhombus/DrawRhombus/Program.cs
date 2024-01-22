using System;
using System.Configuration;

namespace DrawRhombus {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("made by jkrat");
            Console.WriteLine("Type Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[size, size];

            DrawRhombus(array, size);
        }
        static void DrawRhombus(string[,] array, int size) {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (i+j==size-1-size/2 || i-1 == j-1-size/2 || i-1 == j-1+size/2 || i+j == size-1+size/2) {
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