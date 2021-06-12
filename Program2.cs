using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread proces = new System.Threading.Thread(new ThreadStart(solucion));
            proces.Start();
        }
        static void solucion()
        {
            int num;
            Console.WriteLine("Ingrese la cantidad de numeros a ingresar");
            num = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[num];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Numero [" + (i + 1) + "] : ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int J = 0;
            while (J == 0)
            {
                int r = 0;
                Console.WriteLine("Que deceas Hacer");
                Console.WriteLine("(1)\tOrdenar <");
                Console.WriteLine("(2)\tOrdenar >");
                Console.WriteLine("(3)\tHallar Menor");
                Console.WriteLine("(4)\tHallar Mayor");
                Console.WriteLine("(5)\tHallar Promedio");
                Console.WriteLine("(6)\t\tSalir");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        OAscendente(A);
                        break;
                    case 2:
                        ODescendiente(A);
                        break;
                    case 3:
                        Menor(A);
                        break;
                    case 4:
                        Mayor(A);
                        break;
                    case 5:
                        Promedio(A);
                        break;
                    case 6:
                        J = 1;
                        break;
                }
            }
        }
        static void OAscendente(int[] A)
        {
            int aux;
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < (A.Length - 1); i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        aux = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = aux;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
        static void ODescendiente(int[] A)
        {
            int aux;
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < (A.Length - 1); i++)
                {
                    if (A[i] < A[i + 1])
                    {
                        aux = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
        static void Menor(int[] A)
        {
            int Menor = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    Menor = A[i];
                }
                else if (Menor > A[i]) {

                    Menor = A[i];
                }
            }
            Console.WriteLine("El Menor es : " + Menor);
        }
        static void Mayor(int[] A)
        {
            int Mayor = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    Mayor = A[i];
                }
                else if (Mayor < A[i])
                {

                    Mayor = A[i];
                }
            }
            Console.WriteLine("El Mayor es : " + Mayor);
        }
        static void Promedio(int[] A)
        {
            int P = 0;
            for (int i = 0; i < A.Length; i++)
            {
                P = P + A[i];
            }
            Console.WriteLine("EL PROMEDIO ES : " + P);
        }
    } 
}
