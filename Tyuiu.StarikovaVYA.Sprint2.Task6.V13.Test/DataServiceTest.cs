using Tyuiu.StarikovaVYA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.StarikovaVYA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 2020;
            int m = 2;
            int n = 28;
            var res = ds.FindDateOfNextDay(g, m, n);
            double wait = 20200229;
            Assert.AreEqual(wait, res);
        }
    }
}
