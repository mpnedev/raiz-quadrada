using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double A = Math.Sqrt(a);
            Console.WriteLine(A);
        }
    }
}
