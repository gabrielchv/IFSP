Console.Write("Digite o primeiro valor: ");
int valor_um = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int valor_dois = int.Parse(Console.ReadLine());

int valor_temp = valor_um;
valor_um = valor_dois;
valor_dois = valor_temp;

Console.WriteLine("Valor um trocado: "+valor_um+ "; Valor dois trocado: "+valor_dois);