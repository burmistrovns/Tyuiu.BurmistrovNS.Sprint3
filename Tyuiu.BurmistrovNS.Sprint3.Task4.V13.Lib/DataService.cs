using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BurmistrovNS.Sprint3.Task4.V13.Lib
{
    public class DataService : ISprint3Task4V13
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    res = res * (Math.Sin(i) / Math.Cos(i));
                }
            }
            return Math.Round(res, 3);
        }
    }
}