using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9 {
    internal class Program {
        static void Main(string[] args) {
            int vel = Convert.ToInt32(Console.ReadLine());
            string[,] pole = new string[vel, vel];
            Nakreslit(pole, vel);
        }
        static void Nakreslit(string[,] pole, int vel) {
            for (int i = 0; i < vel; i++) {
                for (int j = 0; j < vel; j++) {
                    if (j == vel-1 && i > vel/2 && i < vel || i == vel-1 || i == vel/2 || 
                        j == 0 && i > vel/2 && i < vel-1 || i-1 == j-1-vel/2 || i+j == vel-1-vel/2) {
                        pole[i, j] = "#";
                        Console.Write(pole[i, j]);
                    } else {
                        pole[i, j] = ".";
                        Console.Write(pole[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
