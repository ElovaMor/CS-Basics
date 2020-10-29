/*
 * Студент: Барановва Виталина Васильевна
 * Задача 2.2 
 * Написать метод подсчета количества цифр числа.
*/

using HW_11;
using System;

namespace HW_12
{
	class Program
	{
		static int Quantity(int n)
		{
			int count = 0;

			while (n != 0)
			{
				count ++;

				n = n / 10; // так как n-целое, деление целочисленное	
			}

			return count;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Программа считает количество цифр в заданном числе. Введите число: ");

			int n = int.Parse(Console.ReadLine());

			int count = Quantity(n);

			Console.WriteLine(count);

			Methods.Pause();
		}
	}
}
