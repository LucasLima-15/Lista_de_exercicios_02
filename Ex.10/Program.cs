/*
10. Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das
passagens vendidas. até que ele digte um valor negativo. O total de passagens vendidas deve ser calculado e apresentado utilizando while,
do while e for 
 */

using System;

public class passagem
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int passagem = 1;
        int total = 0;
        
        while (passagem >= 0)
        {   
            Console.WriteLine("Digite a quantidade de passagens vendidas (número negativo encerrar o programa): ");
                passagem = int.Parse(Console.ReadLine());
            if (passagem >= 0)
            {
                total += passagem;
            }
        }    
        Console.WriteLine($"Você vendeu total de {total} passagem(s). ");    
    {
        /*Utilizando DO*/
        int passagem_do = 1;
        int total_do = 0;
        
        do
        {   
            Console.WriteLine("Digite a quantidade de passagens vendidas (número negativo encerrar o programa): ");
                passagem_do = int.Parse(Console.ReadLine());
            if (passagem_do >= 0)
            {
                total_do += passagem_do;
            }
        }
        while (passagem_do >= 0);
        Console.WriteLine($"Você vendeu total de {total_do} passagem(s). ");
      {
        /*Utilizando FOR*/
        int passagem_for = 1;
        int total_for = 0;
        
        for (; passagem >= 0;)
        {   
            Console.WriteLine("Digite a quantidade de passagens vendidas (número negativo encerrar o programa): ");
                passagem_for = int.Parse(Console.ReadLine());
            if (passagem_for >= 0)
            {
                total_for += passagem_for;
            }
        }

        Console.WriteLine($"Você vendeu total de {total_for} passagem(s). ");    
    }
}
