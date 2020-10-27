// Студент: Баранова Виталина Васильевна
// Задача 1
// Написать программу "Анкета". Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
// В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

using System;

namespace HW_01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Это программа <Анкета>, вам необходимо ввести некоторые ваши личные данные.\nДробная часть в соответствующих числах отделяется запятой.");

			string Surname = "Ваша фамилия: ";
			Console.WriteLine(Surname);
			string surname = Console.ReadLine();

			string Name = "\nВаше имя: ";
			Console.WriteLine(Name);
			string name = Console.ReadLine();

			string Age = "\nВаш возраст: ";
			Console.WriteLine(Age);
			string age = Console.ReadLine();

			string Height = "\nВаш рост: ";
			Console.WriteLine(Height);
			double height = double.Parse(Console.ReadLine());

			string Weight = "\nВаш вес: ";
			Console.WriteLine(Weight);
			string weight = Console.ReadLine();

			/////////////////////// а) Склеивание

			string Result = Surname + surname + Name + name + Age + age + Height + height + Weight + weight;
			Console.WriteLine("Спасибо! Результат: \n" + Result);

			/////////////////////// б) Форматированный вывод

			int a = int.Parse(age);

			double h = Convert.ToDouble(height);

			double w = double.Parse(weight);

			Console.WriteLine("\nСпасибо! Результат: \nФамилия - {0};\n Имя - {1};\n Возраст - {2:D1};\n Рост - {3:F};\n Вес - {4:F1}.", surname, name, a, h, w);

			/////////////////////// в) Вывод со знаком $ (интерполяция)

			Console.WriteLine($"\nСпасибо! Результат: \nФамилия - {surname};\n Имя - {name};\n Возраст - {a:D1};\n Рост - {h:F};\n Вес - {w:F1}.");

			Console.ReadLine();

		}
	}
}
