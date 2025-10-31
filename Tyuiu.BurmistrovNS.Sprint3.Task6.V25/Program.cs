using Tyuiu.BurmistrovNS.Sprint3.Task6.V25.Lib;
namespace Tyuiu.BurmistrovNS.Sprint3.Task6.V25
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма делителей меньше 10 = {ds.GetSumTheDivisors(startValue, stopValue)}");

            Console.ReadKey();

        }



    }




}