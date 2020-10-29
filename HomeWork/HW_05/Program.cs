/*
Студент: Баранова Виталина Васильевна
Задача 5
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y)
*/

using HW_06;
using System;

namespace HW_05
{
	class Program
	{
		static void PrintCenter(string msg)
		{
			Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.WindowHeight / 2);
			Console.WriteLine(msg);
		}
		static void Main(string[] args)
		{
			string msg = "Баранова Виталина Васильевна Комсомольск-на-Амуре";

			PrintCenter(msg);

			Methods.Pause();
		}
	}
}
