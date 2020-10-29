/*
 * Студент: Баранова Виталина Васильевна
 * Задача 2.1
 * Написать метод, возвращающий минимальное из трех чисел.
*/

using System;

namespace HW_11
{
	class Program
	{
		static double ThirdMin(double a, double b, double c)
		{
			// если а больше b, то Истина: min=a : Ложь: min=b
			double min = (a < b) ? a : b;

			if (min > c) min = c;

			return min;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Минимальное число из трех. Введите три числа: ");
			double a = Double.Parse(Console.ReadLine());
			double b = Double.Parse(Console.ReadLine());
			double c = Double.Parse(Console.ReadLine());

			Console.WriteLine("Результат выполнения программы: " + ThirdMin(a, b, c));

			Methods.Pause();
		}
	}
}
