using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado 1...");
            string lado1 = Console.ReadLine();
            Console.WriteLine("Digite o lado 2...");
            string lado2 = Console.ReadLine();
            Console.WriteLine("Digite o lado 3...");
            string lado3 = Console.ReadLine();

            Double a = Convert.ToDouble(lado1);
            Double b = Convert.ToDouble(lado2);
            Double c = Convert.ToDouble(lado3);

            Double semi = a + b + c;
            Double área = semi / 2;
            
            Double semi1 = área - a;
            Double semi2 = área - b;
            Double semi3 = área - c;

            Console.WriteLine("Área:" + " " + Math.Sqrt (área * semi1 * semi2 *semi3));
            Console.WriteLine("Semiperímetro:" + área);



        }
    }
}
