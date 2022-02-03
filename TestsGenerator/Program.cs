using System;
using System.IO;
using TestGenerator;
using TestsGeneratorLib;

namespace TestsGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] srcFiles = new string[]
            {
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\FirstFile.cs.cs",
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\SecondFile.cs.cs"
            };
            string dstPath = "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Tests";
            int pipelineLimit = 2;
            new Conveyer().startConveyer(srcFiles, dstPath, pipelineLimit);
            Console.ReadLine();
        }
    }
}