// David Steven Villamizar López
// Grupo 213022_375
// Ingenieria de sistemas
// Codigo fuente: autoria propia

using System;

namespace MatrizDiagonales
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3]; // Crear una matriz de 3x3
            int sumaDiagonal1 = 0, sumaDiagonal2 = 0; // Variables para las sumas de cada diagonal
            double promedioDiagonal1, promedioDiagonal2;

            // Capturar los 9 números para llenar la matriz
            Console.WriteLine("Ingrese 9 números entre 100 y 200 para llenar la matriz de 3x3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int numero;
                    do
                    {
                        Console.Write($"Ingrese el número para la posición [{i},{j}]: ");
                        numero = int.Parse(Console.ReadLine());
                    } while (numero < 100 || numero > 200); // Validar que esté en el rango [100, 200]

                    matriz[i, j] = numero; // Asignar el número a la posición correspondiente en la matriz

                    // Calcular la suma de la primera diagonal (de izquierda a derecha)
                    if (i == j)
                    {
                        sumaDiagonal1 += matriz[i, j];
                    }

                    // Calcular la suma de la segunda diagonal (de derecha a izquierda)
                    if (i + j == 2)
                    {
                        sumaDiagonal2 += matriz[i, j];
                    }
                }
            }

            // Calcular los promedios de cada diagonal
            promedioDiagonal1 = sumaDiagonal1 / 3.0;
            promedioDiagonal2 = sumaDiagonal2 / 3.0;

            // Mostrar la matriz
            Console.WriteLine("\nMatriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }

            // Mostrar los resultados de las sumas y promedios
            Console.WriteLine($"\nSuma de la diagonal que inicia en (0,0): {sumaDiagonal1}");
            Console.WriteLine($"Promedio de la diagonal que inicia en (0,0): {promedioDiagonal1:F2}");
            Console.WriteLine($"Suma de la diagonal que inicia en (0,2): {sumaDiagonal2}");
            Console.WriteLine($"Promedio de la diagonal que inicia en (0,2): {promedioDiagonal2:F2}");

            // Determinar cuál diagonal tiene la mayor suma y promedio
            if (sumaDiagonal1 > sumaDiagonal2)
            {
                Console.WriteLine("\nLa diagonal que inicia en (0,0) tiene el mayor resultado en suma.");
            }
            else if (sumaDiagonal2 > sumaDiagonal1)
            {
                Console.WriteLine("\nLa diagonal que inicia en (0,2) tiene el mayor resultado en suma.");
            }
            else
            {
                Console.WriteLine("\nAmbas diagonales tienen la misma suma.");
            }

            if (promedioDiagonal1 > promedioDiagonal2)
            {
                Console.WriteLine("La diagonal que inicia en (0,0) tiene el mejor promedio.");
            }
            else if (promedioDiagonal2 > promedioDiagonal1)
            {
                Console.WriteLine("La diagonal que inicia en (0,2) tiene el mejor promedio.");
            }
            else
            {
                Console.WriteLine("Ambas diagonales tienen el mismo promedio.");
            }

            // Pausar la consola antes de cerrar
            Console.WriteLine("\nPresione Enter para cerrar...");
            Console.ReadLine();
        }
    }
}
