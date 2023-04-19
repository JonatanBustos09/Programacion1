namespace Proyecto_1
{
    public class Program
    {
        static void Main()
        {
             Console.WriteLine("Hola te voy a ir pidiendo los valores de los 12 meses");
             int sumita = 0;

            for (int mes = 0; mes <= 15; mes++)
            {
                Console.WriteLine("Poneme el valor del mes:" + mes);
                string valor = Console.ReadLine();
                sumita = sumita + int.Parse(valor);
            }
            Console.WriteLine(sumita);
        }
    }
}







/* Ejercicio para calcular la edad
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Puede ingresar su año de nacimiento?");
string LoQueElTipoPuso = Console.ReadLine();
// si voy a calcular mas o menos la edad que tiene tomando su año de nacimiento.
// tendria que calcular así:
int ElAnioDelPibeEnInt = int.Parse(LoQueElTipoPuso);
int ElAnioDondeEstoyAhora = DateTime.Today.Year;
int LaEdadDelFlaco = ElAnioDondeEstoyAhora - ElAnioDelPibeEnInt;

Console.WriteLine("Vos tenes o vas a cumplir este año: " + LaEdadDelFlaco);
*\

