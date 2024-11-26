using Tyuiu.BelousovaOD.Sprint5.Task7.V30.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\Users\79519\source\repos\Tyuiu.BelousovaOD.Sprint5\DataSprint5\InPutDataFileTask7V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
