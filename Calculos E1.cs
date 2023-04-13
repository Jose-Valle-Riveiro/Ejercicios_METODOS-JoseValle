using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_13_04_JV
{
    public class Calculos_E1
    {
        //METODO CUADRADO
        public double AreaCuadrado(double lado)
        {
            double area = Math.Pow(lado, 2);

            return area;
        }

        //METODO TRIANGULO

        public double AreaTriangulo(double Base, double Altura)
        {
            double area = (Base * Altura) / 2;
            return area;
        }

        //METODO CIRCULO
        public double AreaCirculo(double radio)
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
