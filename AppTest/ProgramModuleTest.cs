using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class ProgramModuleTest
    {
        public Program Program;
        [TestInitialize]
        public void Startup()
        {
            Program = new Program();
        }
        // [TestMethod]
        // public void Test_Program_Add_To_Collection()
        // {
        //     Program.Run();
        // }
    }
}