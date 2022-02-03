using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using TestsGeneratorLib;
using TestsGeneratorLib.FileElements;

namespace TestProject
{
    public class Tests
    {
        StreamReader reader;
        [SetUp]
        public void Setup()
        {
            reader = new StreamReader("C:\\Users\\Анастасия\\source\\repos\\TestsGenerator\\Example\\FirstFile.cs");
        }

        [Test]
        public void Test1()
        {
            string code = reader.ReadToEnd();
            Assert.NotNull(code);
        }

        [Test]
        public void Test2()
        {
            FileElement fileElement = null;
            string code = reader.ReadToEnd();
            CodeParser codeParser = new CodeParser();
            fileElement = codeParser.GetFileElement(code);
            Assert.NotNull(fileElement);
        }

        [Test]
        public void Test3()
        {
            Dictionary<string, string> tests;
            FileElement fileInfo = null;
            string code = reader.ReadToEnd();
            CodeParser codeParser = new CodeParser();
            fileInfo = codeParser.GetFileElement(code);
            Generator generator = new Generator();
            tests = generator.GenerateTests(fileInfo);
            Assert.IsNotEmpty(tests);
        }

        [Test]
        public void Test4()
        {
            MethodElement methodElement = new MethodElement("newMethod", "string", new Dictionary<string, string>());
            Assert.AreEqual("string", methodElement.ReturnType);
        }
    }
}