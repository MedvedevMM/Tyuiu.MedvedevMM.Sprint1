using Tyuiu.MedvedevMM.Sprint1.Task6.V6.Lib;
namespace Tyuiu.MedvedevMM.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Test = "Программирование это пизда";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(Test);
            string wait = "рограммирование то изда";
            Assert.AreEqual(wait, res);

        }
    }
}