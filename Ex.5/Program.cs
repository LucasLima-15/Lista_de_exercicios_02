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
        int produto = 1;
        int recebido = 0;
        int vendido = 0;
        

        do
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
        while (produto != 0);
        Console.WriteLine($"O seu estoque está com {recebido} produtos, e vendeu {vendido} produtos. ")
          
    {
        /*U\tilizando FOR*/
        int produto = 1;
        int recebido = 0;
        int vendido = 0;
        
        for (; produto != 0;)
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
        
    }
}
