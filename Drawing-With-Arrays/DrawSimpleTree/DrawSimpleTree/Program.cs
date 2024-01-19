using System;

namespace DrawSimpleTree {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("made by jkrat");
            Console.WriteLine("Type Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[size, size];

            DrawSimpleTree(array, size);
        }
        static void DrawSimpleTree(string[,] array, int size) {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (j == size/2 || size % 2 == 0 && j == size/2-1 ||
                        i == size-2 || i/2+size/2 == j && i < size-1 ||
                        i/2+j == size/2-1 && i < size-1
                        ) {
                        Console.Write(array[i, j] + "*");
                    } else {
                        Console.Write(array[i, j] + ".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
