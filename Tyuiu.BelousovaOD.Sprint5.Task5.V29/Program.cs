﻿using Tyuiu.BelousovaOD.Sprint5.Task5.V29.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Белоусова О. Д. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Выполнила: Белоусова Ольга Дмитриевна | СМАРТБ-24-1           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти сумму всех четных целых чисел в файле. Полученный результат       *");
            Console.WriteLine("* вывести  на консоль. У вещественных значений округлить до трёх знаков   *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\alina\source\repos\Tyuiu.BelousovaOD.Sprint5\InPutDataFileTask5V29.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Сумма чётных элементов файла = {res}");
            Console.ReadKey(); ;
        }
    }
}
