using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.OgorodnikDV.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            string file = Path.GetTempFileName();
            double res = Math.Round((Math.Pow(x, 3)) / (Math.Pow(x, 2) - 1), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return file;
        }
    }
}
