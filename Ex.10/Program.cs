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
        int passagem = 1;
        int total = 0;
        
        do
        {   
            Console.WriteLine("Digite a quantidade de passagens vendidas (número negativo encerrar o programa): ");
                passagem = int.Parse(Console.ReadLine());
            if (passagem >= 0)
            {
                total += passagem;
            }
        }
        while (passagem >= 0);
        Console.WriteLine($"Você vendeu total de {total} passagem(s). ");
      {
        /*Utilizando FOR*/
        int passagem = 1;
        int total = 0;
        
        for (; passagem >= 0;)
        {   
            Console.WriteLine("Digite a quantidade de passagens vendidas (número negativo encerrar o programa): ");
                passagem = int.Parse(Console.ReadLine());
            if (passagem >= 0)
            {
                total += passagem;
            }
        }

        Console.WriteLine($"Você vendeu total de {total} passagem(s). ");    
    }
}
