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

        [TestMethod]
        public void TestMult() {

            var val1 = 2;
            var val2 = 3;


            var ops = new Operations();
            var res = ops.Multiply(val1,val2);

            Assert.AreEqual(6, res);
        }

        /*
        [TestMethod]
        public void TestMod() {

            var val1 = 6;
            var val2 = 3;


            var ops = new Operations();
            var res = ops.Mod(val1,val2);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestDiv() {

            var val1 = 6;
            var val2 = 3;


            var ops = new Operations();
            var res = ops.Divide(val1,val2);

            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void TestDiv_DivideByZeroError() {

            var val1 = 6;
            var val2 = 0;


            var ops = new Operations();
            Assert.ThrowsException<System.DivideByZeroException>(()=> ops.Divide(val1,val2));

        }
        */
    }
}
