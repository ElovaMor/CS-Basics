/*
Студент: Баранова Виталина Васильевна
Задача 4
Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной. 
*/

using HW_06;
using System;

namespace HW_04
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Это программа обмена значениями двух переменных. Введите переменные a и b ниже:");
			double a, b, c;

			a = Double.Parse(Console.ReadLine());
			b = Double.Parse(Console.ReadLine());

			Console.WriteLine("Введённые переменные: a = {0}, b = {1}.", a, b);

			c = a;
			a = b;
			b = c;

			Console.WriteLine("Результат с использованием буфера: a = {0}, b = {1}.", a, b);

			a = a + b;
			b = a - b;
			a = a - b;

			Console.WriteLine("Результат обратного обмена без использования буфера: a = {0}, b = {1}.", a, b);

			Methods.Pause();
		}
	}
}
