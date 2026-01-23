using Tyuiu.StarikovaVYA.Sprint2.Task2.V30.Lib;
namespace Tyuiu.StarikovaVYA.Sprint2.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDotInShadedArea()
        {
            int x = 2, y = 2;
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}