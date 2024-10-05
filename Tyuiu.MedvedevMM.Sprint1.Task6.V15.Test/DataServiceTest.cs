using Tyuiu.MedvedevMM.Sprint1.Task6.V15.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string LC = "abc@#";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(LC);
            Assert.IsTrue(res);
        }
    }
}