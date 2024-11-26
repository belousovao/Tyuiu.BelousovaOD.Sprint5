using Tyuiu.BelousovaOD.Sprint5.Task6.V18.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Белоусова О. Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текствовых файлов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая находит количество одно-   *");
            Console.WriteLine("* разрядных чисел в файле                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: C:\\Users\\79519\\source\\repos\\Tyuiu.BelousovaOD.Sprint5\\DataSprint5 *");
            string path = @"C:\Users\79519\source\repos\Tyuiu.BelousovaOD.Sprint5\DataSprint5";
            Console.WriteLine("* Результат:                                                              *");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
