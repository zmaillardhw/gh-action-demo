using gh_action_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GhActionDemo.Utility.Tests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var val1 = 2;
            var val2 = 3;


            var ops = new Operations();
            var res = ops.Add(val1,val2);

            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestSubtract()
        {
            var val1 = 2;
            var val2 = 3;


            var ops = new Operations();
            var res = ops.Subtract(val1,val2);

            Assert.AreEqual(-1, res);
        }
    }
}
