namespace Proyecto_1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hola te voy a ir pidiendo los valores de los 12 meses");
            int sumita = 0;

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.WriteLine("Poneme el valor del mes: " + mes);
                string valor = Console.ReadLine();
                sumita = sumita + int.Parse(valor);
            }
            Console.WriteLine("La suma de los valores es: " + sumita);
        }
    }
}

