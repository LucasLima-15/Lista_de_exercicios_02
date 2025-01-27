/*4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média
 * até que o usuário digite O. A solução deve ser implementada usando while, do while e for. */


using System;

public class Atividade
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int idade = 0;
        int total = 0;
        int vezes = 0;
        
        while (idade >= 0)
        {
            Console.WriteLine("Digite a idade (Digite um número negativo para encerra o programa): ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 0)
            {
                total += idade;
                vezes++;
            }
        }
        Console.WriteLine($"A média de idade é: {total / vezes}");
        }
        {
        /*Utilizando DO*/
        int idade = 0;
        int total = 0;
        int vezes = 0;
        
        do
        {
            Console.WriteLine("Digite a idade (Digite um número negativo para encerra o programa): ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 0)
            {
                total += idade;
                vezes++;
            }
        }
        while (idade >= 0);            
        Console.WriteLine($"A média das idades é: {total / vezes}");
        {
        /*Utilizando FOR*/
        int idade = 0;
        int total = 0;
        int vezes = 0;
        
        for (; idade >= 0;)
        {
            Console.WriteLine("Digite a idade (Digite um número negativo para encerra o programa): ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 0)
            {
                total += idade;
                vezes++;
            }
        }
        Console.WriteLine($"A média das idades é: {total / vezes}");
    }
}
