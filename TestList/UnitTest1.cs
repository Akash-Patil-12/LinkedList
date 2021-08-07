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
        public void Given3NumbersWhenAddedToLinkedListShouldBeAddedToTop()
        {
            list.AddFirst(50);
            list.AddFirst(30);
            int result=list.AddFirst(70);
            Assert.AreEqual(70, result);
        }
        [TestMethod]
        /// <summery>
        /// Test case 2
        /// <summery>
        public void Given3NumbersWhenAddedToLinkedListShouldBeAddedToLast()
        {
            list.Add(50);
            list.Add(30);
            int result = list.Add(70);
            Assert.AreEqual(70, result);
        }
        [TestMethod]
        /// <summery>
        /// Test case 2
        /// <summery>
        public void GivenIntegerPosition_WhenFind_ShouldReturnTrue()
        {
            list.Add(50);
            list.Add(30);
            bool result = list.Search(30);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        /// <summery>
        /// Test case 3
        /// <summery>
        public void GivenNumber_WhenFind_ShouldReturnTrue()
        {
            list.Add(50);
            list.Add(30);
            list.Add(70);
            bool result=list.SearchAndInsert(30, 40);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        /// <summery>
        /// Test case 4
        /// <summery>
        public void GivenNumber_WhenFind_ShouldDeleteNumberReturnTrue()
        {
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            bool result = list.SearchAndDelete(40);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        /// <summery>
        /// Test case 5
        /// <summery>
        public void GivenList_ShouldReturnSize()
        {
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int result = list.Size();
            Assert.AreEqual(3, result);
        }
    }
}
