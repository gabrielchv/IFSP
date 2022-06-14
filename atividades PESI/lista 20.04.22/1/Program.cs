// ALTURA
Console.Write("Digite a altura do retângulo: ");
float altura = float.Parse(Console.ReadLine());

// LADO
Console.Write("Digite o lado do retângulo: ");
float lado = float.Parse(Console.ReadLine());

// RESULTADO
Console.WriteLine("A área do retângulo é: " + lado*altura + " e o seu perímetro é: " + (2*lado + 2*altura));
