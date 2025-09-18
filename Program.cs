using Intro;
//
Calculadora calc = new Calculadora();

Console.WriteLine( "ingrese el numero 1:")
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "ingrese el numero 2:")
int num2 = Convert.ToInt32(Console.ReadLine());

int totalsuma = calc.Suma(1, 2);

//
Console.WriteLine($"el total de la suma es: {totalsuma}")
 