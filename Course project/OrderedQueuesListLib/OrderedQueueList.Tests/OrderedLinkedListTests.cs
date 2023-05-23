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
        private OrderedLinkedList<string>testList;

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.Write("init empty OrderedLinkedList");
            testList = new OrderedLinkedList<string>();
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            testList.Clear();
        }
        [TestMethod]
        public void Add_addElement_countEqualOne()
        {
            testList.Add(new OrderedQueuesListLibrary.Queue<string>());
            Assert.AreEqual(testList.Count, 1);
        }
        [TestMethod]
        public void Add_addFiveElements_countEqualFive()
        {
            testList.Add(new OrderedQueuesListLibrary.Queue<string>());
            testList.Add(new OrderedQueuesListLibrary.Queue<string>());
            testList.Add(new OrderedQueuesListLibrary.Queue<string>());
            testList.Add(new OrderedQueuesListLibrary.Queue<string>());
            testList.Add(new OrderedQueuesListLibrary.Queue<string>());

            Assert.AreEqual(testList.Count, 5);
        }
        [TestMethod]
        public void Remove_addTwoElements_removeOne_countEqualOne()
        {
            OrderedQueuesListLibrary.Queue<string> QueueOne = new OrderedQueuesListLibrary.Queue<string>();
            testList.Add(QueueOne);
            OrderedQueuesListLibrary.Queue<string> QueueTwo = new OrderedQueuesListLibrary.Queue<string>();
            testList.Add(QueueTwo);
            Assert.AreEqual(testList.Count, 2);
            testList.Remove(QueueTwo);
            Assert.AreEqual(testList.Count, 1);
        }
        public void toString_returnStringWithCorrectSequence()
        {
            OrderedQueuesListLibrary.Queue<string> QueueOne = new OrderedQueuesListLibrary.Queue<string>();
            QueueOne.Enqueue("a");
            testList.Add(QueueOne);
            foreach (OrderedQueuesListLibrary.Queue<string> queue in testList)
            {
                Assert.AreEqual(queue.Dequeue(), "a");
            }
        }

    }
}
