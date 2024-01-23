using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4 {
    internal class Program {
        static void Main(string[] args) {
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SinusX(x));
        }
        static double Faktorial(int n) {
            double Factorial = 1;
            for (int i = 2; i <= n; i++) {
                Factorial *= i;
            }
            return Factorial;
        }
        static double SinusX(double x) {
            double vysledek = 0;
            for (int i = 1; i <= 15; i++) {
                vysledek += Math.Pow(-1,i+1)*Math.Pow(x,2*i-1)/Faktorial(2*i-1);
            }
            return vysledek;
        }
    }
}
