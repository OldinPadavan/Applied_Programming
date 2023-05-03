using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderedQueuesListLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedQueueList.Tests
{
    [TestClass]
    public class QueueTests
    {
        private OrderedQueuesListLibrary.Queue<string> testQueue;

        [TestInitialize]
        public void TestInitialize ( )
        {
            Debug.Write("Init empty testQueue");
            testQueue = new OrderedQueuesListLibrary.Queue<string>();
        }

        [TestCleanup]
        public void TestCleanUp ( )
        {
            testQueue.Clear();
        }

        [TestMethod]
        public void Enqueue_addElement_CountPlusOne ( )
        {
            testQueue.Enqueue("a");
            Assert.AreEqual(1, testQueue.Count);
        }

        [TestMethod]
        public void Enqueue_addElements_firstElementEqualA ( )
        {
            testQueue.Enqueue("a");
            testQueue.Enqueue("b");
            testQueue.Enqueue("c");
            testQueue.Enqueue("d");
            testQueue.Enqueue("e");
            Assert.AreEqual("a", testQueue.First());
        }

        [TestMethod]
        public void Enqueue_AddElements_lastElementEqualE ( )
        {
            testQueue.Enqueue("a");
            testQueue.Enqueue("b");
            testQueue.Enqueue("c");
            testQueue.Enqueue("d");
            testQueue.Enqueue("e");

            Assert.AreEqual("e", testQueue.Last());
        }

        [TestMethod]
        public void Enqueue_addSixElements_DataStructureShouldBeEqual()
        {
            System.Collections.Generic.Queue<string> expectedQueue = new System.Collections.Generic.Queue<string>();
            expectedQueue.Enqueue("a");
            expectedQueue.Enqueue("b");
            expectedQueue.Enqueue("c");
            expectedQueue.Enqueue("d");
            expectedQueue.Enqueue("e");

            testQueue = new OrderedQueuesListLibrary.Queue<string>();
            testQueue.Enqueue("a");
            testQueue.Enqueue("b");
            testQueue.Enqueue("c");
            testQueue.Enqueue("d");
            testQueue.Enqueue("e");

        while(testQueue.Count > 0)
            {
                Assert.AreEqual (expectedQueue.Dequeue(), testQueue.Dequeue());
            }    
        }

        [TestMethod]
        public void Count_addSixElements_returnCountSix()
        {
            testQueue.Enqueue("a");
            testQueue.Enqueue("b");
            testQueue.Enqueue("c");
            testQueue.Enqueue("d");
            testQueue.Enqueue("e");
            testQueue.Enqueue("f");

            Assert.IsTrue(testQueue.Count == 6);
        }
        
    }

}
