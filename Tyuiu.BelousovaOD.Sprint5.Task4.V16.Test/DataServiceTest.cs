﻿using Tyuiu.BelousovaOD.Sprint5.Task4.V16.Lib;
namespace Tyuiu.BelousovaOD.Sprint5.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\azhur\AppData\Local\Temp\DataSprint5\InPutDataFileTask4V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
