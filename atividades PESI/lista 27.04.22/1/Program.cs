Console.Write("Digite sua altura: ");
float altura = float.Parse(Console.ReadLine());
Console.Write("Digite o seu sexo, sendo 'F' para feminino e 'M' para masculino: ");
string sexo = Console.ReadLine();
double peso = 0;

if(sexo == "F" || sexo == "f"){
    peso = 62.1 * altura - 44.7;
}
if(sexo == "M" || sexo == "m"){
    peso = 72.7 * altura - 58;
}

Console.WriteLine("Seu peso ideal é: "+peso);