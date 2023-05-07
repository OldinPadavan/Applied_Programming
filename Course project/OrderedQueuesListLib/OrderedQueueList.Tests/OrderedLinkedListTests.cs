using OrderedQueuesListLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedQueueList.Tests
{
    [TestClass]
    public class OrderedLinkedListTests
    {
        private OrderedLinkedList<OrderedQueuesListLibrary.Queue<string>> testList;

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.Write("init empty OrderedLinkedList");
            testList = new OrderedLinkedList()<>;
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            testList.Clear();
        }
        [TestMethod]
        public void Add_addElement_countEqualOne()
        {
            testList.Add(new OrderedQueuesListLibrary.Queue<T>());
            Assert.AreEqual(testList.Count(), 1);
        }
        [TestMethod]
        public void Add_addFiveElements_countEqualFive()
        {
            testList.Add(new OrderedQueuesListLibrary.Queue<T>());
            testList.Add(new OrderedQueuesListLibrary.Queue<T>());
            testList.Add(new OrderedQueuesListLibrary.Queue<T>());
            testList.Add(new OrderedQueuesListLibrary.Queue<T>());
            testList.Add(new OrderedQueuesListLibrary.Queue<T>());

            Assert.AreEqual(testList.Count(), 5);
        }
        [TestMethod]
        public void Remove_addTwoElements_removeOne_countEqualOne()
        {
            OrderedQueuesListLibrary.Queue<T> QueueOne = new OrderedQueuesListLibrary.Queue<T>();
            testList.Add(QueueOne);
            OrderedQueuesListLibrary.Queue<T> QueueTwo = new OrderedQueuesListLibrary.Queue<T>();
            testList.Add(QueueTwo);
            Assert.AreEqual(testList.Count(), 2);
            testList.Remove(QueueTwo);
            Assert.AreEqual(testList.Count(), 1);
        }
        public void toString_returnStringWithCorrectSequence()
        {
            OrderedQueuesListLibrary.Queue<T> QueueOne = new OrderedQueuesListLibrary.Queue<T>();
            QueueOne.Enqueue("a");
            testList.Add(QueueOne);
            Assert.AreEqual(QueueOne.ToString(), )
        }

    }
}
