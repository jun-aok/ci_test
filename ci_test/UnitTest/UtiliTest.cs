using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
namespace UnitTest {
    [TestClass]
    public class UtiliTest {
        [TestMethod]
        public void AddTest() {
            Assert.AreEqual(Util.Add(1, 1), 2);
            Assert.AreEqual(Util.Add(1, 10), 11);
            Assert.AreEqual(Util.Add(5, 5), 10);
        }
    }
}
