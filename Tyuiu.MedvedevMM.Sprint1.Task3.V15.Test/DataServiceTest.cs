using Tyuiu.MedvedevMM.Sprint1.Task3.V15.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double v1 = 60;
            double v2 = 80;
            double S = 100;
            double T = 2;
            double wait = 380.000;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(wait, res);
        }
    }
}