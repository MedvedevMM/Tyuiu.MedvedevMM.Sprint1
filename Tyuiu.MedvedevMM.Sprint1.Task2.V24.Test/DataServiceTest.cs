using Tyuiu.MedvedevMM.Sprint1.Task2.V24.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 2;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(8, res);
        }
    }
}