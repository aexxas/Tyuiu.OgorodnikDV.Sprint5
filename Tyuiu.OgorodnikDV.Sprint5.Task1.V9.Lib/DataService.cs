using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            //указываем файл
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            //проверка на сущ файла 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist) //для обновы файла
            {
                File.Delete(path); 
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) + Math.Cos(2 * x) / 2 - 1.5 * x;
                y = Math.Round(y, 2);

                strY = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}
