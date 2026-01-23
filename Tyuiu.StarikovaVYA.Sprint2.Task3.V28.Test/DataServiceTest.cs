using Tyuiu.StarikovaVYA.Sprint2.Task3.V28.Lib;
namespace Tyuiu.StarikovaVYA.Sprint2.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 1.881;
            Assert.AreEqual(wait, res);
        }
    }
}
