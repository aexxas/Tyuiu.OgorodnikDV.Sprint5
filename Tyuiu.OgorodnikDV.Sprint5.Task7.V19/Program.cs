using Tyuiu.OgorodnikDV.Sprint5.Task7.V19.Lib;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Огородник Д.В. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все удвоенные буквы сс из файла.                                *");
            Console.WriteLine("* Полученный результат сохранить в файл.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask7V19.txt";
            string res = File.ReadAllText(path);
            Console.WriteLine(res); Console.WriteLine("Файл находится тут: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string w = DataService.LoadDataAndSave(path);
            Console.WriteLine("Cоздан!");
            Console.ReadKey();
        }
    }
}
