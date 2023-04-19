static void Main(string[] args)
{
    int miMAx = 0;
    int nota = 0;
    
    for (int i = 1; i <= 7; i++)
    {
        Console.WriteLine("ingresame la nota  " + i);
        string ingreso = Console.ReadLine();

        nota = int.Parse(ingreso);

        if (nota > miMAx)
        {
            // Acabo de leer una nota que es mayor a mi max actual, así que lo cambio
            miMAx = nota;
        }
    }
    Console.WriteLine("El mayor resultó ser:" + miMAx);
}