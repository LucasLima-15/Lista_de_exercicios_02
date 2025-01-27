/*2. Um usuário quer calcular suas despesas mensais. O exercicio consiste em solicitar ao usuário que insira suas despesas até que ele
 * digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while
 * e for*/

using System;

class Program
{
	static void Main()
	{
		/*Utilizando WHILE*/
    double total = 0;
		double despesas = 0;
		
		while (despesas >= 0)
		{  
		    Console.WriteLine("Digite o valor da despesa (utilize um valor negativo para encerrar o programa): ");
		    despesas = double.Parse(Console.ReadLine());
                if (despesas >= 0 )
                {
                    total+=despesas;
                }
		    
		}
		Console.WriteLine($"O valor total de suas despesas são: R${total}.");
	}	
  {
		/*Utilizando DO*/
    double total = 0;
		double despesas = 0;
		
        do
		{  
		    Console.WriteLine("Digite o valor da despesa (utilize um valor negativo para encerrar o programa): ");
		    despesas = double.Parse(Console.ReadLine());
                if (despesas >= 0 )
                {
                    total+=despesas;
                }
		}     
		while (despesas >= 0);   
		Console.WriteLine($"O valor total de suas despesas são: R${total}.");
    }
  	{
  		/*Utilizando FOR*/
      double total = 0;
  		double despesas = 0;
  		
          for (; despesas >= 0;) 
  		{  
  		    Console.WriteLine("Digite o valor da despesa (utilize um valor negativo para encerrar o programa): ");
  		    despesas = double.Parse(Console.ReadLine());
                  if (despesas >= 0 )
                  {
                      total+=despesas;
                  }
  		}     
  		Console.WriteLine($"O valor total de suas despesas são: R${total}.");
    }
  
}
