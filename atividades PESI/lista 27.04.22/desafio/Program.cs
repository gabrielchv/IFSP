Console.Write("Digite um número: ");
float num1 = float.Parse(Console.ReadLine());
Console.Write("Digite mais um número: ");
float num2 = float.Parse(Console.ReadLine());
Console.Write("Digite mais um número: ");
float num3 = float.Parse(Console.ReadLine());
Console.Write("Digite mais um número: ");
float num4 = float.Parse(Console.ReadLine());
Console.Write("Digite mais um número: ");
float num5 = float.Parse(Console.ReadLine());

double S = 6*num1 + 5*num2 + 4*num3 + 3*num4 + 2*num5;
double digitoV = S%7;

Console.WriteLine("O dígitoV é: "+digitoV);