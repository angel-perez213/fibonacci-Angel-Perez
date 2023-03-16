using System;

namespace fibonacci_Angel_Perez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un número entero mayor que 0: ");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    throw new Exception("El número ingresado no es mayor que 0.");
                }

                int a = 0, b = 1, c = 0;
                Console.WriteLine("La sucesión del numero 0 hasta el término es:", n);
                Console.Write("{0} {1}", a, b);

                while (c < n)
                {
                    c = a + b;
                    if (c <= n)
                    {
                        Console.Write(" {0}", c);
                    }
                    a = b;
                    b = c;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
    }
