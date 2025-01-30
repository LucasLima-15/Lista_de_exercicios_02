/*2. Um usuário quer calcular suas despesas mensais. O exercicio consiste em solicitar ao usuário que insira suas despesas até que ele
 * digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while
 * e for*/


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
	
  {
		/*Utilizando DO*/
        double total_do = 0;
		double despesas_do = 0;
		
        do
		{  
		    Console.WriteLine("Digite o valor da despesa (utilize um valor negativo para encerrar o programa): ");
		    despesas_do = double.Parse(Console.ReadLine());
                if (despesas_do >= 0 )
                {
                    total_do+=despesas_do;
                }
		}     
		while (despesas_do >= 0);   
		Console.WriteLine($"O valor total de suas despesas são: R${total_do}.");
    }
  	{
  		/*Utilizando FOR*/
        double total_for = 0;
  		double despesas_for = 0;
  		
        for (; despesas_for >= 0;) 
  		{  
  		    Console.WriteLine("Digite o valor da despesa (utilize um valor negativo para encerrar o programa): ");
  		    despesas_for = double.Parse(Console.ReadLine());
                  if (despesas_for >= 0 )
                  {
                      total_for+=despesas_for;
                  }
  		}     
  		Console.WriteLine($"O valor total de suas despesas são: R${total_for}.");
    }
 
