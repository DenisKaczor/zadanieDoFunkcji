using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
	internal class Program
	{
		static double ZnajdzWieksza(double a, double b)
		{

			double dlugosc;
			if (a > b)
			{
				dlugosc = a - b;
			}
			else
			{
				dlugosc = b - a;
			}
			return dlugosc;
		}
		static double ObliczDlugoscOdcinka(double x1, double x2, double y1, double y2)
		{
			double dlugosc;
			if (x1==x2)
			{
				dlugosc = ZnajdzWieksza(y1, y2);
			}
			else if (y1==y2)
			{
				dlugosc = ZnajdzWieksza(x1, x2);
			}
			else
			{
				double x = ZnajdzWieksza(x1, x2);
				double y = ZnajdzWieksza(y1, y2);
				x = Math.Pow(x,2);
				y = Math.Pow(y,2);
				dlugosc = Math.Sqrt(x+y);
			}
			return dlugosc;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("podaj parametr x pierwszego punktu");
			double x1  = double.Parse(Console.ReadLine());
			Console.WriteLine("podaj parametr x drugiego punktu");
			double x2 = double.Parse(Console.ReadLine());
			Console.WriteLine("podaj parametr y pierwszego punktu");
			double y1 = double.Parse(Console.ReadLine());
			Console.WriteLine("podaj parametr y drugiego punktu");
			double y2 = double.Parse(Console.ReadLine());
			double dlugosc = ObliczDlugoscOdcinka(x1, x2, y1, y2);
			/////////////////////////////////////////////
			Console.WriteLine("Długość twojego odcinka wynosi: " + dlugosc);
			Console.ReadLine();
		}

	}
}
