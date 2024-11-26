using Tyuiu.BelousovaOD.Sprint5.Task3.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);
        }
    }
}
