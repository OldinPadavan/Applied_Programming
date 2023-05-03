using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderedQueuesListLibrary.Queue;
using System;

namespace OrderedQueuesListLibrary.Tests
{
    [TestClass]
    public class OrderedQueuesListLibTests
    {
        [TestMethod]
        public void Clear_headAndtail_null ( )
        {

        }
    }
    [TestClass]
    public class QueueTests
    {
        private 

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Queue object inizialize");
            TestQueue = new OrderedQueuesListLibrary.Queue<string>();
           


        }

        [TestMethod]
        public static void Queue_empty ( ) { }
    }
}
