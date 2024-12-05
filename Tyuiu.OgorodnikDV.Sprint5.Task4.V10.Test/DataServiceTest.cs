using System.IO;
using Tyuiu.OgorodnikDV.Sprint5.Task4.V10.Lib;

namespace Tyuiu.OgorodnikDV.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint5\Tyuiu.OgorodnikDV.Sprint5.Task4.V10\bin\Debug\net8.0\InPutDataFileTask4V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}