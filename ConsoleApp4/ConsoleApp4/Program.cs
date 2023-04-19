//Ejercicio Suma de notas mas Promedio
Console.WriteLine("Le voy a pedir las notas de las 9 materias del año ");

float sumita = 0;
float promedio = 0f;

for (int notas = 1; notas <= 9; notas++)
{
    Console.WriteLine("Poneme el valor de la siguiente nota: " + notas);
    string valor = Console.ReadLine();
    sumita = sumita + float.Parse(valor);
}
Console.WriteLine(sumita);

promedio = sumita / 9;

Console.WriteLine(promedio);