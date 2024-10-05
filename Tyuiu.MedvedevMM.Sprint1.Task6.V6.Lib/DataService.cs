using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedvedevMM.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            
            foreach (string s in value.Split(' '))
            value = value + " " + s.Substring(1);
            value = value.Trim();
            return value;
        }
    }
}
