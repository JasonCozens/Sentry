using System;
using Ejc.Sentry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions;

namespace Ejc.SentryTests
{
    [TestClass]
    public class HubTests
    {
        /// <summary>
        /// Start by trying the following naming convention.
        /// 
        /// Naming Convention: Method_Expectation.
        /// </summary>
        [TestMethod]
        public void Create_NoListenersRegistered()
        {
            // Act.
            var hub = new Hub();
            // Assert.
            Assert.AreEqual(false, hub.IsRegistered(new object()));
        }

        /// <summary>
        /// Start by trying the following naming convention.
        /// 
        /// Naming Convention: Method_Input_Expectation.
        /// </summary>
        [TestMethod]
        public void Register_Listener_ListenerIsRegistered()
        {
            // Arrange.
            var hub = new Hub();
            var listener = new object();
            // Act.
            hub.Register(listener);
            // Assert.
            Assert.AreEqual(true, hub.IsRegistered(listener));
        }

        [TestMethod]
        public void Unregister_Listener_ListenerIsNotRegistered()
        {
            // Arrange.
            var hub = new Hub();
            var listener = new object();
            hub.Register(listener);
            // Act.
            hub.Unregister(listener);
            // Assert.
            Assert.AreEqual(false, hub.IsRegistered(listener));
        }

        [TestMethod]
        public void Register_OneListener_SecondListenerIsNotRegistered()
        {
            // Arrange.
            var hub = new Hub();
            var listener1 = new object();
            var listener2 = new object();
            // Act.
            hub.Register(listener1);
            // Assert.
           Assert.AreEqual(true, hub.IsRegistered(listener1));
           Assert.AreEqual(false, hub.IsRegistered(listener2));
        }


        [TestMethod]
        public void Register_SameListenerTwice_ThrowsException()
        {
            // Arrange.
            var hub = new Hub();
            var listener = new object();
            hub.Register(listener);
            // Act.
            ThrowsAssert.Throws<InvalidOperationException>(() => hub.Register(listener));
        }
    }
}
