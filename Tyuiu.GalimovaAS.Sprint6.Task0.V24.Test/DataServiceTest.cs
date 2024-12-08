using Tyuiu.GalimovaAS.Sprint6.Task0.V24.Lib;
namespace Tyuiu.GalimovaAS.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}