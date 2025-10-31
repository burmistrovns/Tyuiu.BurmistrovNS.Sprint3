using Tyuiu.BurmistrovNS.Sprint3.Task4.V13.Lib;

namespace Tyuiu.BurmistrovNS.Sprint3.Task4.V13
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
            Console.WriteLine(startValue);
            int stopValue = 5;
            Console.WriteLine(stopValue);
            double res = ds.Calculate(startValue, stopValue);


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Полученное значение = " + res);

            Console.ReadKey();

        }



    }




}