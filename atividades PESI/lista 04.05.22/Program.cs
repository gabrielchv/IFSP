Console.Write("Digite o número da sua agência: ");
String agenciaOriginal = Console.ReadLine();
int[] agencia = new int[agenciaOriginal.Length]; 
    
for (int i = 0; i < agenciaOriginal.Length; i++) { 
    agencia[i] = int.Parse(agenciaOriginal[i].ToString()); 
}

int digitoV = 11 - ((agencia[0] * 5 + agencia[1] * 4 + agencia[2] * 3 + agencia[3] * 2) % 11);

Console.Write(agenciaOriginal + "-" + digitoV);