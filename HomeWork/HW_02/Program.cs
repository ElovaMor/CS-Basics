// Студент: Баранова Виталина Васильевна
// Задача 2
// Ввести вес и рост человека. 
// Рассчитать и вывести индекс массы тела (ИМТ) 
// по формуле I=m/(h*h); 
// где m — масса тела в килограммах, 
// h — рост в метрах

using HW_06;
using System;

namespace HW_02
{
	class Program
	{
		static void Main(string[] args)
		{
			// Запрос имени, потом вопрос, какой у него рост и вес. 
			Console.WriteLine("Привет! Эта программа создана для расчёта индекса массы тела (ИМТ). \nНо перед выполнением программы скажите ваше имя!\n");
			string name = Console.ReadLine();

			Console.WriteLine("Отлично, {0}! Теперь введите ваш вес: ", name);
			double weight = double.Parse(Console.ReadLine());

			Console.WriteLine("И ваш рост (в метрах): ");
			double height = double.Parse(Console.ReadLine());

			double index = weight / Math.Pow(height, 2);
			//index = weight / height* height;
			Console.WriteLine("Спасибо! Вот результат расчёта индекса вашей массы тела: {0:F}.", index);

			Methods.Pause();
		}
	}
}
