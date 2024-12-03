using Tyuiu.OgorodnikDV.Sprint5.Task1.V9.Lib;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint5\Tyuiu.OgorodnikDV.Sprint5.Task1.V9\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wail = true;

            Assert.AreEqual(wail, fileExists);
        }
    }
}