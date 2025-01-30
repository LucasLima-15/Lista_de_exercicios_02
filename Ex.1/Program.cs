/*
1. Um funcionano deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir os dias trabalhados (de 1 a 31)
até que digite 0, que indica que terminou de informar os dias.
O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for
*/

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
		/*utilizando FOR*/
		int contador_for = 0;
	    int dia_for = 1;
		
		for (; dia_for != 0; )
		{  
			Console.WriteLine("Digite o dia trabalhado (de 1 a 31, 0 encerra o programa): ");
			dia_for = int.Parse(Console.ReadLine());
			if (dia_for > 31)
			{
				Console.WriteLine("Dia inválido");
			}

            else if (dia_for < 0)
			{
				Console.WriteLine("Dia inválido");
			}
			else if (dia_for != 0)
				contador_for++;
		}
	}
			Console.WriteLine($"Você trabalhou {contador_for} dias do mês");
	  

	{
		/*utilizando DO*/
	        int contador_do = 0; 
	        int dia_do = 1;
	        do
	        {   
	            Console.WriteLine("Digite o dia trabalhado (0 encerra o programa)");
	            dia_do = int.Parse(Console.ReadLine());
	            if (dia_do > 31)
			    {
			        Console.WriteLine("Dia inválido");
			    }
			    else if (dia_do < 0)
			    {
			        Console.WriteLine("Dia inválido");
			    }  
			    else if (dia_do != 0)
	                contador_do++;
	        }
			while (dia_do != 0);
    Console.WriteLine($"Você trabalhou {contador_do} dias do mês");
	}
