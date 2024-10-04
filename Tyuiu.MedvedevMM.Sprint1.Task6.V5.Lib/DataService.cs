using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedvedevMM.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return ((string)value.Reverse());

            else string.IsNullOrWhiteSpace(value);
                return string.Empty;





        }
    }
}
