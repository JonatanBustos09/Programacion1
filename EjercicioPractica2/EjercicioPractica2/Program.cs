string nombre_completo;
string clave_correcta = "667788";
string clave_prueba;
int numero;
int negativo = 0;
int cantNegativos = 0;
int numeroCuatroCifras;
int cantNumeros = 0;
int sumaNumeros = 0;

Console.WriteLine("Ingrese su nombre completo");
nombre_completo = Console.ReadLine();
Console.WriteLine("Su nombre es: " + nombre_completo);

do
{
    Console.WriteLine("Ingrese su clave");
    clave_prueba = Console.ReadLine();

} while (clave_correcta != clave_prueba);

Console.WriteLine("Ingreso una clave correcta!");

do
{
    Console.WriteLine("Favor de ingresar un número");
    numero = Convert.ToInt32(Console.ReadLine());
    float promedio;
    {
        if (numero < 0)
        {
            cantNegativos++;
            negativo = negativo + numero;
        }
        else
        { 
            promedio = negativo / cantNegativos;
            Console.WriteLine("El promedio de los números negativos ingresados es: " +  promedio);
        }
            
        
    }
} while (numero < 0);
  Console.WriteLine("Ingresó un número positivo!");

do
{
    Console.WriteLine("Favor de ingresar un número de cuatro cifras");
    numeroCuatroCifras = Convert.ToInt32(Console.ReadLine());
    float promedioNumeros;
    
    cantNumeros++;
    sumaNumeros = sumaNumeros + numeroCuatroCifras;
      
    promedioNumeros = sumaNumeros / cantNumeros;
    Console.WriteLine("El promedio de los números negativos ingresados es: " + promedioNumeros);

} while (numeroCuatroCifras < 999);

Console.WriteLine("El número que ingresó es de cuatro cifras y es: " + numeroCuatroCifras);
