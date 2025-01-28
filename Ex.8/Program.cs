/*
B. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de
duração de cada chamada em minutos até que ele digite . O programa deve calcular o total de minutos atendidos, utilizando while, do while
e for
 */

using System;

public class Telefonemas
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int tempo = 0;
        int vezes = 0;
        int total = 0;
        
        while (tempo >= 0)
        {   
            Console.WriteLine("Digite a duração do telefonema em minutos(números negativos para encerrar o programa): ");
                tempo = int.Parse(Console.ReadLine());
                if (tempo >= 0) 
                {
                    vezes++;
                    total += tempo;
                }    
        }    
        Console.WriteLine($"Você passou {total} minutos em ligação de {vezes} telefonema(s). ");    
    {
        /*Utilizando DO*/
        int tempo = 0;
        int vezes = 0;
        int total = 0;
        
        do
        {   
            Console.WriteLine("Digite a duração do telefonema em minutos(números negativos para encerrar o programa): ");
                tempo = int.Parse(Console.ReadLine());
                if (tempo >= 0) 
                {
                    vezes++;
                    total += tempo;
                }    
        }
        while (tempo >= 0);
        Console.WriteLine($"Você passou {total} minutos em ligação de {vezes} telefonema(s). ");    
    {
        /*Utilizando FOR*/
        int tempo = 0;
        int vezes = 0;
        int total = 0;
        
        for (; tempo >= 0;)
        {   
            Console.WriteLine("Digite a duração do telefonema em minutos(números negativos para encerrar o programa): ");
                tempo = int.Parse(Console.ReadLine());
                if (tempo >= 0) 
                {
                    vezes++;
                    total += tempo;
                }    
        }    
        Console.WriteLine($"Você passou {total} minutos em ligação de {vezes} telefonema(s). ");    
    }
}
