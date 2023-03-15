using System;
using System.Globalization;

namespace Triangulo
{
    internal class program
    {
        static void Main(string[] args)
        {

            Calculo t = new Calculo();

            Console.WriteLine("Digite o valor do primeiro lada: ");
            t.X = int.Parse(Console.ReadLine());
            t.RX = Math.Pow(t.X,2);
            Console.WriteLine(t.RX);
            Console.WriteLine("Digite o valor do segundo lado: ");
            t.Y = double.Parse(Console.ReadLine());
            t.RY = Math.Pow(t.Y,2);
            Console.WriteLine(t.RY);
            Console.WriteLine("Digite o valor do terceiro lado: ");
            t.Z = double.Parse(Console.ReadLine());
            t.RZ = Math.Pow(t.Z,2);
            Console.WriteLine(t.RZ);

            if (t.RX >= t.RY + t.RZ)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            if(t.RX == t.RY + t.RZ)
            {
                Console.WriteLine("É UM TRIANGULO RETANGULO");
            }
            if(t.RX > t.RY + t.RZ)
            {
                Console.WriteLine("É UM TRIANGULO OBTUSANGULO");
            }
            if(t.RX < t.RY + t.RZ)
            {
                Console.WriteLine("É UM TRIANGULO ACUTANGULO");
            }
            if (t.RX == t.RY && t.RX != t.RZ)
            {
                Console.WriteLine("É UM TRIANGULO ISOSCELES");
            }
            if (t.RX == t.RY || t.RX == t.RZ || t.RY == t.RZ)
            {
                Console.WriteLine("É UM TRIANGULO EQUILATERO");
            }
            else
            {
              Console.WriteLine("Digite outros valores por favor");
            }



            t.ImprimirDados();


          


           


        }
    }
}//double.Parse(Console.ReadLine("F4", CultureInfo.InvariantCulture))