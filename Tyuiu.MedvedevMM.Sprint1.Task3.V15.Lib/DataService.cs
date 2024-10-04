using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedvedevMM.Sprint1.Task3.V15.Lib
{
    public class DataService : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            double V = v1 + v2;
            double D = V * T;
            double Sn = S + D;
            return Math.Round(Sn, 3);
        } 
    }
}
