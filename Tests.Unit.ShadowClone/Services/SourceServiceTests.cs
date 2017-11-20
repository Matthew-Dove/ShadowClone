using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShadowClone.Services;

namespace Tests.Unit.ShadowClone.Services
{
    [TestClass]
    public class SourceServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new SourceService();

            var result = service.GetSourceDirectory();

            Assert.IsTrue(result);
        }
    }
}
