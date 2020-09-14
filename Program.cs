using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static double[] numeros = { 1.0, 4.0, 9.0, 10.0, 3.0, 6.0, 8.0, 7.0, 5.0, 2.0, 5.4 };
	
	public static void Main()
	{
		double[] newNumeros = numeros.OrderBy(i => i).ToArray();
		Console.WriteLine(@"Sistema calcula a média, a mediana e dá um conceito médio para a lista de números.");

		var mediaNumeros = CalcularMedia();
		var mediaValue = 0.0;
		var getLengthItems = newNumeros.Length;
		Array.Sort(newNumeros);
		if (getLengthItems % 2 == 0)
		{
			var firstValue = newNumeros[(newNumeros.Length / 2) - 1];
			var secondValue = newNumeros[(newNumeros.Length / 2)];
			mediaValue = (firstValue + secondValue) / 2.0;
		}
		if (getLengthItems % 2 == 1)
		{
			mediaValue = newNumeros[(newNumeros.Length / 2)];
		}
		
		Console.WriteLine("A média dos números é " + mediaNumeros);
		Console.WriteLine("O valor mediano de números é " + mediaValue);

		MostrarConceito(mediaNumeros);
		
		Console.WriteLine(@"A execução acabou, tecle enter para sair...");

		Console.ReadLine();
		
	}

	private static double CalcularMedia()
	{
		return numeros.Average();
	}

	private static void MostrarConceito(double mediaNumeros)
	{
		if (mediaNumeros >= 9) { Console.WriteLine("O conceito para a lista de números é A"); }
		if (mediaNumeros >= 7.5 && mediaNumeros < 9) { Console.WriteLine("O conceito para a lista de números é B"); }
		if (mediaNumeros >= 6.0 && mediaNumeros < 7.5) { Console.WriteLine("O conceito para a lista de números é C"); }
		if (mediaNumeros >= 4.0 && mediaNumeros < 6.0) { Console.WriteLine("O conceito para a lista de números é D"); }
		if (mediaNumeros < 4) { Console.WriteLine("O conceito para a lista de números é E"); }
	}

}