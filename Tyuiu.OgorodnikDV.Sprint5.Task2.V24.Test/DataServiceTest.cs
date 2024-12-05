using Tyuiu.OgorodnikDV.Sprint5.Task2.V24.Lib;

namespace Tyuiu.OgorodnikDV.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint5\Tyuiu.OgorodnikDV.Sprint5.Task2.V24\bin\Debug\net8.0\OutPutFileTask2.xlsx";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wail = true;

            Assert.AreEqual(wail, fileExists);
        }
    }
}