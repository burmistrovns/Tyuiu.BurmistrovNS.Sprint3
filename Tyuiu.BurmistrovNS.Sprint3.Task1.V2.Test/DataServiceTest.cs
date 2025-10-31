using Tyuiu.BurmistrovNS.Sprint3.Task1.V2.Lib;

namespace Tyuiu.BurmistrovNS.Sprint3.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            var res = ds.GetSumSeries(startValue, stopValue);
            var next = 0.968;
            Assert.AreEqual(next, res);
        }
    }
}
