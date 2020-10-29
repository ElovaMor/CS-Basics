/*
 * Студент: Баранова Виталина Васильевна
 * Задача 2.3 
 * С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел.
 */


using HW_11;
using System;

namespace HW_13
{
	class Program
	{
		static bool Search(int a)
		{
			return (a > 0) && (a % 2 != 0);
		}
		static void Main(string[] args)
		{
			int x, sum = 0;
			Console.WriteLine("Программа вычисляет сумму всех положительных нечётных чисел из тех, что будут введены пользователем.\nЧтобы закончить, введите 0.");
			
			do
			{
				x = int.Parse(Console.ReadLine());
				sum += (Search(x)) ? x : 0;
			}
			while (x != 0);

			Console.WriteLine($"Сумма всех положительных нечётных чисел, введённых пользователем, равна {sum}.");

			Methods.Pause();
		}
	}
}
