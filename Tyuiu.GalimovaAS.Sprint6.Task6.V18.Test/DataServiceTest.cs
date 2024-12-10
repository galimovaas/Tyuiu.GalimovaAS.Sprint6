using Tyuiu.GalimovaAS.Sprint6.Task6.V18.Lib;
namespace Tyuiu.GalimovaAS.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint6\DataSprint6\InPutDataFileTask6V18.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB ";
            Assert.AreEqual(wait, res);
        }
    }
}