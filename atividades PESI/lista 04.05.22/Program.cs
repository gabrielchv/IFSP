float[,] valores = new float[3, 4];
const float multiplicador = 3.2f;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("Digite um valor: ");
        valores[i, j] = float.Parse(Console.ReadLine());
        valores[i, j] *= multiplicador;
    }
}
