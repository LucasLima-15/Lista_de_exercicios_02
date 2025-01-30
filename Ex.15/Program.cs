/*Desafio: Criar um programa que receba 6 nome utilizando arrays. Ao final o programa deve exibir todos os nome digitados */

string[] nomes = new string[6];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o nome da posição {i + 1}º: ");
    nomes[i] = Console.ReadLine();
}

Console.Clear();
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"O nome {nomes[i]} esta na posição {i + 1}");
}