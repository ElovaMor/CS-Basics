/*
 * Студент: Баранова Виталина Васильевна
 * Задача 2.4
 * Реализовать метод проверки логина и пароля. 
 * На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, 
 * и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, 
 * написать программу: 
 * пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

using System;
using HW_11;

namespace HW_14
{
	class Program
	{
		static bool Password(string log, string passw)
		{
			string login = "root", password = "GeekBrains";

			bool pass = (login == log && password == passw) ? true : false;

			return pass;
		}
		static void Main(string[] args)
		{
			int trying = 3;
			bool pass = false;
			string log, passw;

			do
			{
				Console.WriteLine($"Введите логин и пароль. У вас {trying} попыток.");
				log = Console.ReadLine();
				passw = Console.ReadLine();

				pass = Password(log, passw);

				-- trying; 
			}
			while (trying != 0 && pass == false);

			if (pass == true)
			{
				Console.WriteLine("Авторизация прошла успешно!");
			}
			else
			{
				Console.WriteLine("Авторизация провалилась.");
			}

			Methods.Pause();
		}
	}
}
