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
        int comprasdo = 1;
        int totaldo = 0;
        
        do
        {   
            Console.WriteLine("Digite o valor da compra (0 encerrar o programa): ");
                comprasdo = int.Parse(Console.ReadLine());
            totaldo += comprasdo;
        }
        while (compras != 0);
        Console.WriteLine($"Você gastou R${total} em suas compra(s). ");    
    {
        /*Utilizando FOR*/
        int comprasfor = 1;
        int totalfor = 0;
        
        for (; comprasfor != 0;)
        {   
            Console.WriteLine("Digite o valor da compra (0 encerrar o programa): ");
                comprasfor = int.Parse(Console.ReadLine());
            totalfor += comprasfor;
        }    
        Console.WriteLine($"Você gastou R${total} em suas compra(s). ");    
