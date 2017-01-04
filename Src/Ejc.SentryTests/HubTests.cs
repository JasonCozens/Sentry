using Ejc.Sentry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejc.SentryTests
{
    [TestClass]
    public class HubTests
    {
        [TestMethod]
        public void Create_Hub()
        {
            // Act.
            var hub = new Hub();
            // Assert.
            Assert.AreNotEqual(null, hub);
        }
    }
}
