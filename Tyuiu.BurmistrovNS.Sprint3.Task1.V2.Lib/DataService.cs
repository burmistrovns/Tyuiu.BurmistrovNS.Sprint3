using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BurmistrovNS.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            while (startValue <= stopValue)
            {
                res = res + (Math.Sin(startValue) * 0.5);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}