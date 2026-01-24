using Tyuiu.StarikovaVYA.Sprint2.Task4.V19.Lib;

namespace Tyuiu.StarikovaVYA.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 36.754;
            Assert.AreEqual(wait, res);
        }
    }
}