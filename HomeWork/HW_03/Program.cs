/*
Студент: Баранова Виталина Васильевна
Задача 3

а) Написать программу, которая подсчитывает расстояние между точками 
с координатами x1, y1 и x2,y2 
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

б) *Выполните предыдущее задание, оформив вычисления 
расстояния между точками в виде метода.
*/

using System;

namespace HW_03
{
	class Program
	{
		static double Distance(double x1, double y1, double y2, double x2)
		{
			double x, y;

			x = x2 - x1;
			y = y2 - y1;

			double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

			return result;
		}
		static void Main(string[] args)
		{
			double x1, y1, x2, y2;

			Console.WriteLine("Данная программа вычисляет расстояние между точками (X1; Y1) и (X2; Y2).");

			Console.WriteLine("Введите координаты X1 и Y1:");
			x1 = double.Parse(Console.ReadLine());
			y1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите координаты X2 и Y2:");
			x2 = double.Parse(Console.ReadLine());
			y2 = double.Parse(Console.ReadLine());

			double result = Distance(x1, y1, x2, y2);

			Console.WriteLine("Расстояние между точками с координатами ({0}; {1}) и ({2}; {3}) равно: {4:F}.", x1, y1, x2, y2, result);

			Console.ReadLine();
		}
	}
}
