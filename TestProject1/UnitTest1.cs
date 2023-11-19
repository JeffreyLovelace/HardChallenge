using SmartVault.CodeGeneration;
using SmartVault.Program.BusinessObjects;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWriteEveryThirdFileToFile()
        {
            SmartVault.Program.Program.WriteEveryThirdFileToFile("1");
        }
        [TestMethod]
        public void TestGetAllFileSizes()
        {
            SmartVault.Program.Program.GetAllFileSizes();
        }
    }
}