using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] array =
			{
			{1,2,3,4,5 },
			{ 6,7,8,9,0 },
			{10, 11, 12, 13, 14 },
			{ 1, 3,3,4,5 } };
			znajdzNajbardziejPodobneWiersze(array, out int row1, out int row2);
			Console.WriteLine($"Najbardziej podobne wiersze: {row1} i {row2}");
			Console.ReadKey();
		}
		static void znajdzNajbardziejPodobneWiersze(int[,] array, out int row1, out int row2)
		{
			row1 = 0;
			row2 = 0;

			long najmniejszaRoznica = long.MaxValue;

			int iloscWierszy = array.GetLength(0);
			int iloscKolumn = array.GetLength(1);


			for (int i = 0; i < iloscWierszy; i++)
			{
				for (int j = i + 1; j < iloscWierszy; j++)
				{
					long roznica = wyliczRoznice(array, i, j);
					if (roznica < najmniejszaRoznica)
					{
						najmniejszaRoznica = roznica;
						row1 = i;
						row2 = j;
					}
				}
			}
		}

		static long wyliczRoznice(int[,] array, int i, int j)
		{
			int iloscKolumn = array.GetLength(1);
			long roznica = 0;

			for (int kol = 0; kol < iloscKolumn; kol++)
			{
				roznica += (long)Math.Pow(array[i, kol] - array[j, kol], 2);
			}
			return roznica;
		}
	}

}
