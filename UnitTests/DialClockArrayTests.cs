using Lab9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DialClockArrayTests
    {
        [TestMethod]
        public void DialClockArray_DefaultConstructor_ShouldCreateEmptyArray()
        {
            DialClockArray dca = new DialClockArray();
            Assert.AreEqual(0, dca.ReturnArrayLength());
        }

        [TestMethod]
        public void DialClockArray_DefaultConstructor_ShouldAutoCreateArray()
        {
            int size = 5;
            DialClockArray dca = new DialClockArray(size);
            Assert.AreEqual(size, dca.ReturnArrayLength());
        }

        [TestMethod]
        public void DialClockArray_CopyConstructor_ShouldCopyArray()
        {
            DialClockArray source = new DialClockArray(3);
            DialClockArray dca = new DialClockArray(source);
            Assert.AreEqual(source.ReturnArrayLength(), dca.ReturnArrayLength());
            for (int i = 0; i < source.ReturnArrayLength(); i++)
            {
                Assert.AreEqual(source[i].Hours, dca[i].Hours);
                Assert.AreEqual(source[i].Minutes, dca[i].Minutes);
            }
        }

    }
}
