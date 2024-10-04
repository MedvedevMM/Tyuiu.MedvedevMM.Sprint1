using Tyuiu.MedvedevMM.Sprint1.Task6.V5.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string srtTest = "казак";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(srtTest);
            string wait = "казак";
            Assert.AreEqual(wait, res);
        }
    }
}