using Tyuiu.OgorodnikDV.Sprint5.Task0.V21.Lib;
using System.IO; // для использ класса file

namespace Tyuiu.OgorodnikDV.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint5\Tyuiu.OgorodnikDV.Sprint5.Task0.V21\bin\Debug\net8.0\OutputFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wail = true;

            Assert.AreEqual(wail, fileExists);
        }
    }
}