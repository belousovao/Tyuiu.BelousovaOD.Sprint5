using System.IO;
using Tyuiu.BelousovaOD.Sprint5.Task0.V25.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            var res = ds.SaveToFileTextData(3);
            string wait = "9,037";
            Assert.AreEqual(wait, File.ReadAllText(res));
        }
    }
}
