using Lab9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void DialClockArray_CopyConstructor_ShouldCopyEmptyArray()
        {
            DialClockArray source = new DialClockArray(0);
            DialClockArray dca = new DialClockArray(source);
            Assert.AreEqual(source.ReturnArrayLength(), dca.ReturnArrayLength());
            for (int i = 0; i < source.ReturnArrayLength(); i++)
            {
                Assert.AreEqual(source[i].Hours, dca[i].Hours);
                Assert.AreEqual(source[i].Minutes, dca[i].Minutes);
            }
        }

        [TestMethod]
        public void DialClockArray_ReturnArrayLength_ShouldReturnLength()
        {
            int size = 5;
            DialClockArray arr = new DialClockArray(5);
            Assert.AreEqual(size, arr.ReturnArrayLength());
        }

        [TestMethod]
        public void DialClockArray_ArraysCounter_ShouldReturnNumberOfArrays()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                DialClockArray arr = new DialClockArray(2);
                count++;
            }
            Assert.AreEqual(count, DialClockArray.ArraysCounter());
        }

        [TestMethod]
        public void DialClockArray_ObjectsCounter_ShouldReturnNumberOfObjects()
        {
            int count = 0;
            int size = 2;
            for (int i = 0; i < 5; i++)
            {
                DialClockArray arr = new DialClockArray(size);
                count += size;
            }
            Assert.AreEqual(count, DialClockArray.ObjectsCounter());
        }

        [TestMethod]
        public void DialClockArray_Indexer_ShouldReturnObjectWithIndex()
        {
            DialClockArray arr = new DialClockArray(10);
            DialClock clock1 = arr[5];
            arr[3] = clock1;
            DialClock clock2 = arr[-1];
            DialClock clock3 = arr[11];
            arr[-1] = clock1;
            arr[11] = clock2;
            Assert.AreEqual(clock1, arr[5]);
            Assert.AreEqual(arr[3], clock1);
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void DialClockArray_UserConstructor_ShouldReturnObjectWithUserParameters()
        {
            int size = 5;
            DialClockArray arr = new DialClockArray(5, "Элемент");
            Assert.AreEqual(size, arr.ReturnArrayLength());
        }

    }
}
