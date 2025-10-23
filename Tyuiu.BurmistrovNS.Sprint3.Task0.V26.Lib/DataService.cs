using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BurmistrovNS.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                p *= (Math.Pow(2, k) / (k + 1.0)) * Math.Cos(1.8);
            }

            return Math.Round(p, 3);
        }
    }
}