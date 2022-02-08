using System;
using System.IO;
using System.Threading.Tasks;
using TestsGeneratorLib;

namespace TestsGenerator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string[] srcFiles = new string[]
            {
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\FirstFile.cs",
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\SecondFile.cs",
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\Class1.cs",
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\Class2.cs"
            };
            string dstPath = "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Tests";
            int pipelineLimit = 1;
            Conveyer conveyer = new Conveyer();
            await conveyer.startConveyer(srcFiles, dstPath, pipelineLimit);
        }
    }
}