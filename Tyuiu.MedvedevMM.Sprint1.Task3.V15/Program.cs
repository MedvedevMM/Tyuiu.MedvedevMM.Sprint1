using Tyuiu.MedvedevMM.Sprint1.Task3.V15.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Медведев М.М. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Медведев Матвей Максимович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1, v2, S, T;

            Console.WriteLine("Введите cкорость первого автомобиля:");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Скорость второго автомобиля:");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Начальное расстояние между автомобилями:");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Время движения:");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговое расстояние между автомобилями = " + ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadKey();
        }
    }
}
