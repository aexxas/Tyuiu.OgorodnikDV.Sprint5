using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            //указываем файл
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.xlsx");

            //проверка на сущ файла 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist) //для обновы файла
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1; // кол-во строк
            int colu = matrix.Length / rows; // кол-во столбов 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colu; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }

                }
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colu; j++)
                {
                    if (j != colu - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }

                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";



            }
            return path;
        }
    }
}
