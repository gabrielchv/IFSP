Console.Write("Digite o valor do saque: ");
int valor_usuario = int.Parse(Console.ReadLine());

int r100 = valor_usuario / 100;
int r50 = valor_usuario % 100 / 50;
int r20 = valor_usuario % 100 % 50 / 20;
int r10 = valor_usuario % 100 % 50 % 20 / 10;
int r5 = valor_usuario % 100 % 50 % 20 % 10 / 5;
int r2 = valor_usuario % 100 % 50 % 20 % 10 % 5 / 2;
int r1 = valor_usuario % 100 % 50 % 20 % 10 % 5 % 2;

Console.WriteLine("notas de 100 reais: "+r100);
Console.WriteLine("notas de 50 reais: "+r50);
Console.WriteLine("notas de 20 reais: "+r20);
Console.WriteLine("notas de 10 reais: "+r10);
Console.WriteLine("notas de 5 reais: "+r5);
Console.WriteLine("notas de 2 reais: "+r2);
Console.WriteLine("notas de 1 real: "+r1);
