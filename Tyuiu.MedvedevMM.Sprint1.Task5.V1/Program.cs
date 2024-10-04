using Tyuiu.MedvedevMM.Sprint1.Task5.V1.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Медведев М.М. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Медведев Матвей Максимович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
