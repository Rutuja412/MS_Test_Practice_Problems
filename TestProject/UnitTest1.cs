using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingPracticeProblem;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1ShuldReturnTrue()
        {
            SwapCompetition swap = new SwapCompetition();

            Assert.IsTrue(swap.areAnagram("part", "trap"));

        }
        [TestMethod]
        public void ShuldReturnFalse()
        {
            SwapCompetition swap = new SwapCompetition();
            Assert.IsFalse(swap.areAnagram("noon", "moon"));
        }
    }
}
