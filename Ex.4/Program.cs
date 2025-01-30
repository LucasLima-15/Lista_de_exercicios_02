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
        int idade_do = 0;
        int total_do = 0;
        int vezes_do = 0;
       
        do

    }
        /*Utilizando FOR*/
        int idade_for = 0;
        int total_for = 0;
        int vezes_for = 0;
        
        for (; idade_for >= 0;)
        {
            Console.WriteLine("Digite a idade (Digite um número negativo para encerra o programa): ");
            idade_for = int.Parse(Console.ReadLine());
            if (idade_for > 0)
            {
                total_for += idade_for;
                vezes_for++;
            }
        }
        Console.WriteLine($"A média das idades é: {total_for / vezes_for}");
    }

}