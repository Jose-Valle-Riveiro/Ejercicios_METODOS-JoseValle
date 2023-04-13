using Ejercicios_13_04_JV;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using static System.Formats.Asn1.AsnWriter;

class Metodos
{
    static void Main(string[] args)
    {
        Calculos_E1 m = new Calculos_E1();
        Electrodomestico e = new Electrodomestico();
        bool seguirMenu = true;
        while(seguirMenu == true)
        {
            Console.WriteLine("HOJA DE TRABAJOS: METODOS");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("INGRESE UNA OPCION:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1) Ejercicio 1");
            Console.WriteLine("2) Ejercicio 2");
            Console.WriteLine("3) Ejercicio 3");
            Console.WriteLine("4) Salir ");
            Console.WriteLine("------------------------------------------");

            char opcionMenu = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (opcionMenu)
            {
                case '1':
                    bool seguir = true;

                    do
                    {
                        //EJERCICIO 1 //CALCULAR AREAS

                        Console.WriteLine("EJERCICIO 1");
                        Console.WriteLine("Ingrese el numero de area a calcular");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("1) Area de un cuadrado");
                        Console.WriteLine("2) Area de un triangulo");
                        Console.WriteLine("3) Area de un circulo");
                        Console.WriteLine("------------------------------------------");

                        int opcion = Convert.ToInt32(Console.ReadLine());
                        double dato, dato2;
                        switch (opcion)
                        {

                            case 1:
                                Console.WriteLine("Ingrese la longitud del lado cuadrado");
                                dato = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine(m.AreaCuadrado(dato) + " u2");
                                break;

                            case 2:
                                Console.WriteLine("Ingrese la longitud de la base");
                                dato = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Ingrese la longitud de la altura");
                                dato2 = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine(m.AreaTriangulo(dato, dato2) + " u2");
                                break;

                            case 3:
                                Console.WriteLine("Ingrese la longitud del radio del circulo");
                                dato = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine(m.AreaCirculo(dato) + " u2");
                                break;


                        }
                        Console.WriteLine("¿DESEA CONTINUAR? // S o N");

                        char escoge = Convert.ToChar(Console.ReadLine());
                        if (escoge == 's')
                        {
                            seguir = true;
                        }
                        else
                        {
                            seguir = false;
                        }

                        Console.Clear();
                    } while (seguir == true);
                    break;

                case '2':
                    //EJERCICIO 2
                    bool seguir2 = true;
                    while (seguir2 == true)
                    {

                        Console.WriteLine("EJERCICIO 2");
                        Console.WriteLine("Ingrese el precio base del producto: ");
                        double precio = Convert.ToDouble(Console.ReadLine());

                        bool CharValido = false;
                        char consumo;
                        do
                        {
                            Console.WriteLine("Ingrese el consumo energetico (A, B, C o D): ");
                            consumo = Convert.ToChar(Console.ReadLine());

                            if (consumo == 'A' || consumo == 'B' || consumo == 'C' || consumo == 'D')
                            {
                                CharValido = true;
                            }
                            else
                            {
                                Console.WriteLine("CARACTER INVALIDO");

                            }

                        } while (CharValido == false);

                        Console.WriteLine("Ingrese el peso del producto");

                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("El valor del producto es: Q" + e.CalcularPrecio(precio, consumo, peso));

                        Console.WriteLine("Desea continuar? // S o N");
                        char escoge = Convert.ToChar(Console.ReadLine());
                        if (escoge == 's')
                        {
                            seguir2 = true;
                        }
                        else
                        {
                            seguir2 = false;
                        }
                        Console.Clear();

                    }
                    break;

                case '3':

                    //EJERCICIO 3
                    Console.WriteLine("EJERCICIO 3");
                    Console.WriteLine("Ingrese el numero para conseguir los divisores");

                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.Write("DIVISORES: ");
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;


                case '4':
                    seguirMenu = false;
                  break;
            }           
        }      
    }
}
