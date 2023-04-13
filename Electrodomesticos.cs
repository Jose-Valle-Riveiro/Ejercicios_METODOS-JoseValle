using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_13_04_JV
{
    public class Electrodomestico
    {
        public double CalcularPrecio(double precioB, char CE, double peso)
        {
            double PrecioT = precioB;
            switch (CE)
            {
                case 'A':
                    PrecioT = PrecioT + 100;
                    break;

                case 'B':
                    PrecioT = PrecioT + 80;
                    break;

                case 'C':
                    PrecioT = PrecioT + 60;
                    break;

                case 'D':
                    PrecioT = PrecioT + 50;
                    break;

            }

            if (peso >= 20 && peso < 40)
            {
                PrecioT = PrecioT + (PrecioT * 0.05);
            }
            else if (peso >= 40)
            {
                PrecioT = PrecioT + (PrecioT * 0.10);
            }

            return PrecioT;

        }
    }
}
