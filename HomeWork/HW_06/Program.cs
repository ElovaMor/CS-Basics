/*
Студент: Баранова Виталина Васильевна
Задача 6*
Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
*/

using System;

namespace HW_06
{
	class Program
	{
		static void Print(string msg, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(msg);
		}
		static void Print(string msg)
		{
			Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.WindowHeight / 2);
			Console.WriteLine(msg);
		}
		static void Pause()
		{
			Console.ReadLine();
		}
	}
}
