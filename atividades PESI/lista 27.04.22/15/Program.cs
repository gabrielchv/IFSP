Console.Write("Digite o valor da cotação do dólar: ");
float cotacao = float.Parse(Console.ReadLine());
Console.Write("Digite o valor de dólares que deseja converter em reais: ");
float dolares = float.Parse(Console.ReadLine());

double reais = dolares * cotacao;
Console.WriteLine("Você possuirá "+reais+" reais se converter seus dólares!");