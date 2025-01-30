/*7. Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuario insira as distâncias percomdas
 * em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de
 * repetição. */

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int distancia = 0;
        int dias = 0;
        int total = 0;
        
        while (distancia >= 0)
        {   
            Console.WriteLine("Digite quantos Km você percorreu no dia (utilize números negativo para encerra o programa): ");
                distancia = int.Parse(Console.ReadLine());
                if (distancia >= 0) 
                {
                    dias++;
                    total += distancia;
                }    
        }    
        Console.WriteLine($"Você percorreu {total} Km em {dias} dia(s). ");    
    {
        /*Utilizando DO*/
        int distancia_do = 0;
        int dias_do = 0;
        int total_do = 0;
        
        do
        {   
            Console.WriteLine("Digite quantos Km você percorreu no dia (utilize números negativo para encerra o programa): ");
                distancia_do = int.Parse(Console.ReadLine());
                if (distancia_do >= 0) 
                {
                    dias_do++;
                    total_do += distancia_do;
                }  
        }
        while (distancia_do >= 0);
        Console.WriteLine($"Você percorreu {total_do} Km em {dias_do} dia(s). ");    
    {
        /*Utilizando FOR*/
        int distancia_for = 0;
        int dias_for = 0;
        int total_for = 0;
        
        for (; distancia_for >= 0;)
        {   
            Console.WriteLine("Digite quantos Km você percorreu no dia (utilize números negativo para encerra o programa): ");
                distancia_for = int.Parse(Console.ReadLine());
                if (distancia_for >= 0) 
                {
                    dias_for++;
                    total_for += distancia_for;
                }    
        }    
        Console.WriteLine($"Você percorreu {total_for} Km em {dias_for} dia(s). ");    
    }
}
