using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("Seleccione una figura para calcular su volumen:");
            Console.WriteLine("1. Cilindro");
            Console.WriteLine("2. Esfera");
            Console.WriteLine("3. Ortoedro");
            Console.WriteLine("4. Prisma");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            double volumen = 0;
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del cilindro: ");
                    double radioCilindro = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del cilindro: ");
                    double alturaCilindro = double.Parse(Console.ReadLine());
                    volumen = Math.PI * radioCilindro * radioCilindro * alturaCilindro;
                    Console.WriteLine("El volumen del cilindro es: " + volumen);
                    break;
                case 2:
                    Console.Write("Ingrese el radio de la esfera: ");
                    double radioEsfera = double.Parse(Console.ReadLine());
                    volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
                    Console.WriteLine("El volumen de la esfera es: " + volumen);
                    break;
                case 3:
                    Console.Write("Ingrese la longitud del ortoedro: ");
                    double longitudOrtoedro = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho del ortoedro: ");
                    double anchoOrtoedro = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del ortoedro: ");
                    double alturaOrtoedro = double.Parse(Console.ReadLine());
                    volumen = longitudOrtoedro * anchoOrtoedro * alturaOrtoedro;
                    Console.WriteLine("El volumen del ortoedro es: " + volumen);
                    break;
                case 4:
                    Console.Write("Ingrese la longitud de la base del prisma: ");
                    double longitudPrisma = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del prisma: ");
                    double alturaPrisma = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el número de lados de la base del prisma: ");
                    int numLadosPrisma = int.Parse(Console.ReadLine());
                    double apotemaPrisma = (longitudPrisma / (2 * Math.Tan(Math.PI / numLadosPrisma)));
                    volumen = (numLadosPrisma * Math.Pow(longitudPrisma, 2) * apotemaPrisma) / 4 * alturaPrisma;
                    Console.WriteLine("El volumen del prisma es: " + volumen);
                    break;
                case 5:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }
}
