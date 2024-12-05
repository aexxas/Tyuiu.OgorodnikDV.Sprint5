using Tyuiu.OgorodnikDV.Sprint5.Task4.V10.Lib;

namespace Tyuiu.OgorodnikDV.Sprint5.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Огородник Д.В. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х                       *");
            Console.WriteLine("* в формуле y = x3 * 1.2x + 2. Вычислить значение по формуле              *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint5\Tyuiu.OgorodnikDV.Sprint5.Task4.V10\bin\Debug\net8.0\InPutDataFileTask4V10.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
