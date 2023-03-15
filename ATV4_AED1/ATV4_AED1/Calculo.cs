using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Calculo
    {
        private int x;
        private double y;
        private double z;
        private double rx;
        private double ry;
        private double rz;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
          
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;  
            }
        }
        public double RX
        {
            get
            {
                return rx;
            }
            set
            {
                rx = value;
            }

        }
        public double RY
        {
            get
            {
                return ry;
            }
            set
            {
                ry = value;
            }
        }
        public double RZ
        {
            get
            {
                return rz;
            }
            set
            {
                rz = value;
            }
        }



        public void ImprimirDados()
        {
            Console.WriteLine("Primeiro lado: " + rx);
            Console.WriteLine();
            Console.WriteLine("segundo lado: " + ry);
            Console.WriteLine();
            Console.WriteLine("terceiro lado:" + rz);
            Console.WriteLine();

        }
        
    }
}
