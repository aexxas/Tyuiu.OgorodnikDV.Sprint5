using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ' && line[i] != ',' && line[i] != '.' && line[i] != '?')
                        {
                            count += 1;

                        }
                        else
                        {
                            if (count == 6)
                            {
                                res += 1;
                            }
                            count = 0;
                        }
                    }
                }
            }
            return res;
        }
    }
}
