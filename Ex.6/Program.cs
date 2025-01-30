/*6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A., 2
 * para candidato B) ale que ele digite 0. O programa deve contar quantos votos cada candidato recebeu implementando a solução com while,
 * do while e for */

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int voto = 1;
        int candidato1 = 0;
        int candidato2 = 0;

        while (voto != 0)
        {
            Console.WriteLine("Qual é seu candidato (1=A 2=B, 0 encerra o programa): ");
            voto = int.Parse(Console.ReadLine());
                if (voto == 1)
            {   
                candidato1++;
            }    
            else if (voto == 2)
            {
                candidato2++;
            }   
        }
        
        Console.WriteLine($"O Candidato A recebeu {candidato1} votos.");
        Console.WriteLine($"Candidato B recebeu {candidato2} votos.");
        Console.WriteLine($"O total de votos foram {candidato1 + candidato2} votos.");
        
   {
        /*Utilizando DO*/
        int voto_do = 1;
        int candidato1_do = 0;
        int candidato2_do = 0;

        do
        {
            Console.WriteLine("Qual é seu candidato (1=A 2=B, 0 encerra o programa): ");
            voto = int.Parse(Console.ReadLine());
            if (voto == 1)
            {   
                candidato1_do++;
            }    
            else if (voto_do == 2)
            {
                candidato2_do++;
            }   
        }
        while (voto_do != 0);
        
        Console.WriteLine($"O Candidato A recebeu {candidato1_do} votos.");
        Console.WriteLine($"Candidato B recebeu {candidato2_do} votos.");
        Console.WriteLine($"O total de votos foram {candidato1 + candidato2} votos.");
        
    {
        /*Utilizando FOR*/
        int voto_for = 1;
        int candidato1_for = 0;
        int candidato2_for = 0;

        for (; voto_for != 0;)
        {
            Console.WriteLine("Qual é seu candidato (1=A 2=B, 0 encerra o programa): ");
            voto_for = int.Parse(Console.ReadLine());
            if (voto_for == 1)
            {   
                candidato1_for++;
            }    
            else if (voto_for == 2)
            {
                candidato2_for++;
            }   
        }
        
        Console.WriteLine($"O Candidato A recebeu {candidato1_for} votos.");
        Console.WriteLine($"Candidato B recebeu {candidato2_for} votos.");
        Console.WriteLine($"O total de votos foram {candidato1_for + candidato2_for} votos.");
        
    }
}
