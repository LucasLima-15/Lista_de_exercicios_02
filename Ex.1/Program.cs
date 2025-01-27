/*
1. Um funcionano deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir os dias trabalhados (de 1 a 31)
até que digite 0, que indica que terminou de informar os dias.
O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for
*/

using System;

class Program
{
	static void Main()
	{
		/*utilizando */
		int contador = 0;
		int dia = 1;
		
		while (dia != 0)
		{  
			  Console.WriteLine("Digite o dia trabalhado (de 1 a 31, 0 encerra o programa): ");
			  dia = int.Parse(Console.ReadLine());
			  if (dia > 31)
			  {
			    Console.WriteLine("Dia inválido");
			  }
			  else if (dia < 0)
			  {
			    Console.WriteLine("Dia inválido");
			  }  
			  else if (dia != 0)
			  {
			    contador++;
			  }
		  }
		  Console.WriteLine($"Você trabalhou {contador} dias do mês");
	  
	}
	{
		/*utilizando DO*/
		int dia = 1;
	        int contador = 0;
	        
	        do
	        {
	            Console.WriteLine("Digite o dia trabalhado (0 encerra o programa): ");
	            dia = int.Parse(Console.ReadLine());
	            if (dia > 31)
			    {
			        Console.WriteLine("Dia inválido");
			    }
			    else if (dia < 0)
			    {
			        Console.WriteLine("Dia inválido");
			    }  
			    else if (dia != 0)
	                contador++;
	        }
	        while (dia != 0);
	        Console.WriteLine($"Você trabalhou {contador} dias do mês.");
	}
	{
		/*utilizando FOR*/
	        int contador = 0; 
	        int dia = 1;
	        for (; dia != 0;)
	        {   
	            Console.WriteLine("Digite o dia trabalhado (0 encerra o programa)");
	            dia = int.Parse(Console.ReadLine());
	            if (dia > 31)
			    {
			        Console.WriteLine("Dia inválido");
			    }
			    else if (dia < 0)
			    {
			        Console.WriteLine("Dia inválido");
			    }  
			    else if (dia != 0)
	                contador++;
	        }
	        Console.WriteLine($"Você trabalhou {contador} dias do mês");
	}
}
