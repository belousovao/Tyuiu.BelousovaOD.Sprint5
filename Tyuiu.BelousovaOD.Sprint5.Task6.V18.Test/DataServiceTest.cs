using Tyuiu.BelousovaOD.Sprint5.Task6.V18.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFileValid()
        {
            string s = @"C:\Users\79519\source\repos\Tyuiu.BelousovaOD.Sprint5\DataSprint5";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            string s = @"C:\Users\79519\source\repos\Tyuiu.BelousovaOD.Sprint5\DataSprint5";
            Assert.AreEqual(ds.LoadFromDataFile(s), 2);
        }
    }
}
