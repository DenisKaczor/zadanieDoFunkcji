using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("podaj czas w sekundach");
			double czas = int.Parse(Console.ReadLine());
			double g = godzina(czas);
			double m = minuta(czas);
			double s = sekunda(czas);
			string timeString = g.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00");
			Console.WriteLine(timeString);
			Console.ReadLine();
		}
		static double godzina(double czas)
		{
			double godziny=0;
			godziny = czas / 3600;
			godziny = Math.Floor(godziny);
			return godziny;
		}
		static double minuta(double czas)
		{
			double minuty;
			minuty = czas/60;
			minuty -= godzina(czas) * 60;
			minuty = Math.Floor(minuty);
			return minuty;
		}
		static double sekunda(double czas)
		{
			double sekundy;
			sekundy = czas/60 - Math.Floor(czas/60);
			sekundy *= 0.6;
			sekundy *= 100;
			sekundy =Math.Round(sekundy);
			return sekundy;
		}

	}
}
