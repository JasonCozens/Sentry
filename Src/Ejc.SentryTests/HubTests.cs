using Ejc.Sentry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
