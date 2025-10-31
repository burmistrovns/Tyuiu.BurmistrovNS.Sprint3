using Tyuiu.BurmistrovNS.Sprint3.Task3.V26.Lib;
namespace Tyuiu.BurmistrovNS.Sprint3.Task3.V26
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string value = "have a nice time";
            char chr = 'e';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + chr);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetCharCount(value, chr));

            Console.ReadKey();

        }



    }




}