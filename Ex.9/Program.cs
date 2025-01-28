/*
 9. Um diente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra
até que ale digite 0. A soma dos valores das compras deve ser implementada usando as três estruturas de repetição. 
 */

using System;

public class compras
{
    public static void Main(string[] args)
    {
        /*Utilizando WHILE*/
        int compras = 1;
        int total = 0;
        
        while (compras != 0)
        {   
            Console.WriteLine("Digite o valor da compra (0 encerrar o programa): ");
                compras = int.Parse(Console.ReadLine());
            total += compras;
        }    
        Console.WriteLine($"Você gastou R${total} em suas compra(s). ");    
    {
        /*Utilizando DO*/
        int compras = 1;
        int total = 0;
        
        do
        {   
            Console.WriteLine("Digite o valor da compra (0 encerrar o programa): ");
                compras = int.Parse(Console.ReadLine());
            total += compras;
        }
        while (compras != 0);
        Console.WriteLine($"Você gastou R${total} em suas compra(s). ");    
    {
        /*Utilizando FOR*/
        int compras = 1;
        int total = 0;
        
        for (; compras != 0;)
        {   
            Console.WriteLine("Digite o valor da compra (0 encerrar o programa): ");
                compras = int.Parse(Console.ReadLine());
            total += compras;
        }    
        Console.WriteLine($"Você gastou R${total} em suas compra(s). ");    
    }
}
