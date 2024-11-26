namespace Tyuiu.BelousovaOD.Sprint5.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "OutPutFileTask0.txt";
            double x9 = -2;
            double result9 = 2 * Math.Pow(x9, 2) + 3 * x9 - 4;
            File.AppendAllText(outputFile, result9.ToString());

        }
    }
}
