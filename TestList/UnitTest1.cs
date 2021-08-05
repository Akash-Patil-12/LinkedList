using DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestList
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList list = new LinkedList();
        [TestMethod]
        /// <summery>
        /// Test case 1
        /// <summery>
        public void GivenIntegerPosition_WhenFind_ShouldReturnTrue()
        {
            list.Add(50);
            list.Add(30);
            bool result = list.Search(30);
            Assert.AreEqual(true, result);
        }
    }
}
