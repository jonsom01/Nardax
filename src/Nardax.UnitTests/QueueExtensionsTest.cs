using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [TestClass]
    public class QueueExtensionsTest
    {
        Queue<string> _queue;

        public QueueExtensionsTest()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");
            _queue.Enqueue("cc");

        }

        [TestMethod]
jiooooooooooooooooooooooonnub
            Assert.AreEqual("bb", _queue.Dequeue());
            Assert.AreEqual("cc", _queue.Dequeue());
            Assert.AreEqual("dd", _queue.Dequeue());
            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
