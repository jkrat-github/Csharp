using System;

namespace ConsoleApp9 {
    internal class Program {
        static void Main(string[] args) {
            int size = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[size, size];
            DrawSimpleHouse(array, size);
        }
        static void DrawSimpleHouse(string[,] array, int size) {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (j == size-1 && i > size/2 && i < size || i == size-1 || i == size/2 || 
                        j == 0 && i > size/2 && i < size-1 || i-1 == j-1-size/2 || i+j == size-1-size/2) {
                        array[i, j] = "#";
                        Console.Write(array[i, j]);
                    } else {
                        array[i, j] = ".";
                        Console.Write(array[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
