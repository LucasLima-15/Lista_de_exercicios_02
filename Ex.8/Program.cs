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
        int tempo_do = 0;
        int vezes_do = 0;
        int total_do = 0;
        
        do
        {   
            Console.WriteLine("Digite a duração do telefonema em minutos(números negativos para encerrar o programa): ");
                tempo_do = int.Parse(Console.ReadLine());
                if (tempo_do >= 0) 
                {
                    vezes_do++;
                    total_do += tempo_do;
                }    
        }
        while (tempo_do >= 0);
        Console.WriteLine($"Você passou {total_do} minutos em ligação de {vezes_do} telefonema(s). ");    
    {
        /*Utilizando FOR*/
        int tempo_for = 0;
        int vezes_for = 0;
        int total_for = 0;
        
        for (; tempo_for >= 0;)
        {   
            Console.WriteLine("Digite a duração do telefonema em minutos(números negativos para encerrar o programa): ");
                tempo_for = int.Parse(Console.ReadLine());
                if (tempo_for >= 0) 
                {
                    vezes_for++;
                    total_for += tempo_for;
                }    
        }    
        Console.WriteLine($"Você passou {total_for} minutos em ligação de {vezes_for} telefonema(s). ");    
    }
}
