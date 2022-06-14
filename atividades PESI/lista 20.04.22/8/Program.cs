// TEMP
Console.Write("Digite uma temperatura em Fahrenheit: ");
float tempF = float.Parse(Console.ReadLine());

float tempC = (tempF - 32) * (5/9);

// RESULTADO
Console.WriteLine("A mesma temperatura em Celsius é: " + ((tempF - 32) / 1.8));
