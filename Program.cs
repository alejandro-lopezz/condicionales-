using System;

namespace ejercicios4p
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ejercicio1
           /* int n1, n2, resultado = 0;

            Cons ole.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número:");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2) {
               resultado = n1 - n2;
            } else if(n1 == n2) {
                resultado = n1 + n2;
            } else if(n1 < n2) {
                resultado = n1 * n2;
            }

            Console.WriteLine("El resultado es: " + resultado); */

            //ejercicio2
            /* float importe;
            float litrosVendidos;

            Console.WriteLine("Ingrese el importe total:");
            importe = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresee los litros vendidos:");
            litrosVendidos = float.Parse(Console.ReadLine());

            if(litrosVendidos > 500) {
                importe = importe * 0.75F;
            } else if(litrosVendidos > 300 && litrosVendidos <= 500) {
                importe = importe * 0.85F;
            } else if(litrosVendidos > 100 && litrosVendidos <= 300) {
                importe = importe * 0.90F;
            } else {
                importe = importe;
            }

            Console.WriteLine("El importe final es: " + importe); */

            //ejercicio3
            /* int procesador;
            int ram;
            int precio = 0;
            int disco;

            Console.WriteLine("Ingrese su procesador:");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su ram:");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si quiere expander disco o 0 si no quiere:");  
            disco = int.Parse(Console.ReadLine());

            switch(procesador) {
                case 1:
                    switch(ram) {
                        case 1:
                        precio = 800;
                        = 1000;
                        break;break;
                        case 2:
                        precio = 900;
                        break;
                        case 3:
                        precio
                }
                break;
                case 2:
                    switch(ram) {
                        case 1:
                        precio = 900;
                        break;
                        case 2:
                        precio = 1000;
                        break;
                        case 3:
                        precio = 1400;
                        break;
                }
                break;
                case 3:
                    switch(ram) {
                        case 1:
                        precio = 1200;
                        break;
                        case 2:
                        precio = 1400;
                        break;
                        case 3:
                        precio = 2000;
                        break;
                }
                break;
            }

            if(disco == 1) {
                precio += 300;
            }

            Console.WriteLine("El precio final es: " + precio); */

            //ejercicio4
            /* int a, b, c;
            int suma, producto;

            Console.WriteLine("Ingresa el primer número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());

            suma = a + b;
            producto = b * c;

            if(suma > producto) {
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");
            } else {
                Console.WriteLine("El producto es mayor que la suma");
            } */


            //ejercicio5
            int a, b, c, d;

            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último:");
            d = int.Parse(Console.ReadLine());

            if(a > b && b > c && c > d) {
                Console.WriteLine("Ordenados en forma decreciente");
            } else {
                Console.WriteLine("No ordenados en forma decreciente");
            }

            /* if(a <= b || a <= c || a <= d) {
                Console.WriteLine("No esta en forma decreciente");
            } else if(b <= c || b <= d) {
                Console.WriteLine("No esta en forma decreciente");
            } else if(c <= d) {
                Console.WriteLine("No esta en forma decreciente");
            } else {
                Console.WriteLine("Esta ordenado en forma decreciente");
            } */
            

        }
    }
}
