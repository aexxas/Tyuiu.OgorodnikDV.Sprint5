using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V19.txt");
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd(); // считывает все символы, начиная с текущей позиции до конца потока
                line = line.ToLower().Replace("сс", "");
            }
            File.WriteAllText(pathsave, line); // записывает весь файл сразу
            return pathsave;
        }
    }
}
