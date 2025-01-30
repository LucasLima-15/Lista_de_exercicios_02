/*3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as notas dos
 * alunos (de 0 a 10) e, ao digitar-1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utikzando
 * as très estruturas de repetição */

/*Utilizando WHILE*/
using System;

public class WhilePrograma
{
    public static void Main(string[] args)
    {
        int aprovado = 0;
        int reprovado = 0;
        double nota = 0;
        
        while (nota >= 0)
        {   
            Console.WriteLine("Digite a nota do aluno (de 0 a 10, utilize número negativo para encerrar o programa): ");
            nota = double.Parse(Console.ReadLine());
                if (nota <= 10)
                {
                    if (nota >= 0)
                    {
                        if (nota >= 6)
                        {
                         aprovado++;
                        }
                        else
                        {
                         reprovado++;
                        }
                    }    
                }     
                else
                    Console.WriteLine("Nota inválida");
        }                   
        Console.WriteLine($"Em sua classe tiveram {aprovado} alunos aprovados e {reprovado} alunos reprovados");
        /*Utilizando DO*/
        int aprovado_do = 0;
        int reprovado_do = 0;
        double nota_do = 0;
        
        do
        {   
            Console.WriteLine("Digite a nota do aluno (de 0 a 10, utilize número negativo para encerrar o programa): ");
            nota = double.Parse(Console.ReadLine());
                if (nota_do <= 10)
                {
                    if (nota_do >= 0)
                    {
                        if (nota_do >= 6)
                        {
                         aprovado_do++;
                        }
                        else
                        {
                         reprovado_do++;
                        }
                    }    
                }     
                else
                    Console.WriteLine("Nota inválida");
        }
        while (nota_do >= 0);
        Console.WriteLine($"Em sua classe tiveram {aprovado_do} alunos aprovados e {reprovado_do} alunos reprovados");

        /*Utilizando FOR*/
        int aprovado_for = 0;
        int reprovado_for = 0;
        double nota_for = 0;
        
        for (; nota_for >= 0;)
        {   
            Console.WriteLine("Digite a nota do aluno (de 0 a 10, utilize número negativo para encerrar o programa): ");
            nota_for = double.Parse(Console.ReadLine());
                if (nota_for <= 10)
                {
                    if (nota_for >= 0)
                    {
                        if (nota_for >= 6)
                        {
                            aprovado_for++;
                        }
                        else
                        {
                            reprovado_for++;
                        }
                    }    
                }     
                else
                    Console.WriteLine("Nota inválida");
        }
        Console.WriteLine($"Em sua classe tiveram {aprovado_for} alunos aprovados e {reprovado_for} alunos reprovados");
    }
}
