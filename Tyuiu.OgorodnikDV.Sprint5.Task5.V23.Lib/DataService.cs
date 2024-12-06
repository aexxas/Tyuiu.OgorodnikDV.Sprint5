using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double min = 100000;
            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    if (Convert.ToDouble(line) < min)
                    {
                        min = Convert.ToDouble(line);
                    }
                }
            }
            return min;
        }
    }
}
