using Tyuiu.BurmistrovNS.Sprint3.Task7.V13.Lib;
namespace Tyuiu.BurmistrovNS.Sprint3.Task7.V13
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.Write("Начало: " + startValue);
            Console.Write("Конец: " + stopValue);

  
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] res = ds.GetMassFunction(startValue, stopValue);
            int len = res.Length;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("X = {0,3} | F(x) = {1,7:F2}", startValue + i, res[i]);
            }

            Console.ReadKey();

        }



    }




}