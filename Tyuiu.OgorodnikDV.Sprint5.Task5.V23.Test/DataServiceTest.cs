using Tyuiu.OgorodnikDV.Sprint5.Task5.V23.Lib;

namespace Tyuiu.OgorodnikDV.Sprint5.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint5\Tyuiu.OgorodnikDV.Sprint5.Task5.V23\bin\Debug\net8.0\InPutDataFileTask5V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}