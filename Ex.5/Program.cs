/*5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos
 * recebidos e vendidos ató que của digito . Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando
 * as três estruturas de repetição */

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int produto = 1;
        int recebido = 0;
        int vendido = 0;
        

        while (produto != 0)
        {
            Console.WriteLine("Digite a quantidade de produtos (utilize positivo para recebido e negativo para vendidos, 0 encerra o programa): ");
            produto = int.Parse(Console.ReadLine());
            if (produto < 0)
            {   
                vendido += produto;
                recebido += produto;                    
                Console.WriteLine($"Produto vendido, total de {recebido} em estoque.");
            }    
            else if (produto > 0)
            {
                recebido += produto;
                Console.WriteLine($"Produto adicionado no estoque! Total de {recebido}");
            }   

        }
        Console.WriteLine($"O seu estoque está com {recebido} produtos, e vendeu {vendido} produtos. ");
        
        {
        /*Utilizando DO*/
        int produto_do = 1;
        int recebido_do = 0;
        int vendido_do = 0;
        

        do
        {
            Console.WriteLine("Digite a quantidade de produtos (utilize positivo para recebido e negativo para vendidos, 0 encerra o programa): ");
            produto_do = int.Parse(Console.ReadLine());
            if (produto_do < 0)
            {   
                vendido_do += produto_do;
                recebido_do += produto_do;                    
                Console.WriteLine($"Produto vendido, total de {recebido_do} em estoque.");
            }    
            else if (produto_do > 0)
            {
                recebido_do += produto_do;
                Console.WriteLine($"Produto adicionado no estoque! Total de {recebido}");
            }   

        }
        while (produto != 0);
        Console.WriteLine($"O seu estoque está com {recebido} produtos, e vendeu {vendido} produtos. ")
          
    {
        /*U\tilizando FOR*/
        int produto_for = 1;
        int recebido_for = 0;
        int vendido_for = 0;
        
        for (; produto != 0;)
        {
            Console.WriteLine("Digite a quantidade de produtos (utilize positivo para recebido e negativo para vendidos, 0 encerra o programa): ");
            produto_for = int.Parse(Console.ReadLine());
            if (produto_for < 0)
            {   
                vendido_for += produto_for;
                recebido_for += produto_for;                    
                Console.WriteLine($"Produto vendido, total de {recebido_for} em estoque.");
            }    
            else if (produto_for > 0)
            {
                recebido_for += produto_for;
                Console.WriteLine($"Produto adicionado no estoque! Total de {recebido_for}");
            }   

        }

        Console.WriteLine($"O seu estoque está com {recebido_for} produtos, e vendeu {vendido_for} produtos. ");
        
    }

}