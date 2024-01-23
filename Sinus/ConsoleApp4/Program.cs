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
        static double Factorial(int n) {
            double Factorial = 1;
            for (int i = 2; i <= n; i++) {
                Factorial *= i;
            }
            return Factorial;
        }
        static double SinusX(double x) {
            double result = 0;
            for (int i = 1; i <= 15; i++) {
                result += Math.Pow(-1,i+1)*Math.Pow(x,2*i-1)/Factorial(2*i-1);
            }
            return result;
        }
    }
}
