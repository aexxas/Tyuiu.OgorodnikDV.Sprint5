using Tyuiu.OgorodnikDV.Sprint5.Task1.V9.Lib;

namespace Tyuiu.OgorodnikDV.Sprint5.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнила: Огородник Д.В. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = sin(x)+(cos(2x)/2) -1,5х (произвести табулирование) *");
            Console.WriteLine("* f(x) на заданном диапазоне [-5,5] с шагом 1.                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл " + res);
            Console.WriteLine($"Создан");
            Console.ReadKey();
        }
    }
}
