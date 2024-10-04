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

            double v1 = 68.51;
            double v2 = 64.91;
            double S = 52.36;
            double T = 3.51;

            Console.WriteLine("Скорость первого автомобиля = " + v1);
            Console.WriteLine("Скорость второго автомобиля = " + v2);
            Console.WriteLine("Начальное расстояние между автомобилями = " + S);
            Console.WriteLine("Время движения = " + T);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговое расстояние между автомобилями = " + ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadKey();
        }
    }
}
