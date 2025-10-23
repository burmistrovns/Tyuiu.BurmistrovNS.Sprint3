using Tyuiu.BurmistrovNS.Sprint3.Task0.V26.Lib;

namespace Tyuiu.BurmistrovNS.Sprint3.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double res = Math.Round(ds.GetMultiplySeries(startValue, stopValue), 3);

            double wait = -15.642;
            Assert.AreEqual(wait, res);
        }
    }
}