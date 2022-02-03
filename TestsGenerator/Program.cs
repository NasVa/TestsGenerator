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
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\Class1.cs",
                "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\Class2.cs"
            };
            string dstPath = "C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Destiny";
            int pipelineLimit = 2;
            new Conveyer().startConveyer(srcFiles, dstPath, pipelineLimit);
            Console.ReadLine();
        }
    }
}