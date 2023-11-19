using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RunCodeGenerator()
        {
            using SmartVaultProgram = SmartVault.Program;

            var businessObjectSourceGenerator = new namespace('SmartVault.CodeGeneration').;

        }
    }
}
