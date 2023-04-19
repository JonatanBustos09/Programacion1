class Program
{
    public static void Main(string[] args)
    {
        int valor;

        Console.WriteLine("Por favor ingrese un valor entero:");
        valor = int.Parse(Console.ReadLine());

        if (valor == 1 || valor == 3 || valor == 5 || valor == 7 || valor == 9)
        {
            Console.WriteLine("El valor ingresado es impar");
        }
        else
        {
            Console.WriteLine("El valor ingresado es par o no está en la lista de impares");
        }

        Console.ReadKey();
    }
}
