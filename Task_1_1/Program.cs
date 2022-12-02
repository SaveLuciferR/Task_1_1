using System;

namespace Task_1_1
{
	class Programm
	{
		static void Main(string[] agrs)
		{
			double a, b, c;

			while (true)
			{
				Console.Write("Введите a: ");
				a = Convert.ToDouble(Console.ReadLine());

				if (a > 0)
				{
					break;
				}

				Console.WriteLine("Катет не может быть отрицательным или равен 0");
			}
			
			while (true)
			{
				Console.Write("Введите b: ");
				b = Convert.ToDouble(Console.ReadLine());

				if (b > 0)
				{
					break;
				}

				Console.WriteLine("Катет не может быть отрицательным или равен 0");
			}

			c = Math.Sqrt(a * a + b * b);
			Console.WriteLine("Периметр равен: " + (a + b + c));
		}
	}
}