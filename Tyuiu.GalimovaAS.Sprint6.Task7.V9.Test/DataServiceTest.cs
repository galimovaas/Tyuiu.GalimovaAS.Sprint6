using Tyuiu.GalimovaAS.Sprint6.Task7.V9.Lib;
namespace Tyuiu.GalimovaAS.Sprint6.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint6\DataSprint6\InPutDataFileTask7V9.csv";

            int[,] res = ds.GetMatrix(path);

            int[,] wait = { { 16, -15, -14, -16, -9, -10, -17, 12, -20, -12 }, { 7, 20, -16, 13, 19, 15, -13, -4, 9, 18, }, { -4, 18, 8, 9, -3, 14, -17, 18, -12, -11 }, { -13, 5, 7, -13, 2, -9, 19, 19, -16, 1 }, { 12, 7, 7, -6, 11, -7, 17, -8, -11, -4 }, { -8, -16, -13, -16, 3, -3, -13, 20, -15, 6 }, { 11, 18, -17, -5, -14, 18, 5, 9, -4, -17 }, { 6, 9, 18, 14, 15, -4, 3, -7, -18, 14 }, { 3, 5, 11, 15, -17, 8, 9, -1, 11, 19 }, { 11, -20, 17, 12, 16, 13, -15, 3, 16, 7 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}