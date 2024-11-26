using Tyuiu.BelousovaOD.Sprint5.Task1.V3.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFileWrite()
        {
            string direct = System.IO.Path.GetTempPath();



            string path = Path.GetTempFileName();
            string apath = Path.Combine(direct, path);

            FileInfo fileInfo = new FileInfo(apath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}
