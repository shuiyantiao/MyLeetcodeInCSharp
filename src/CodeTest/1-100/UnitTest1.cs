namespace MyLeetcodeInCSharp._1_100.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void TwoSumTest1()
        {
            var t = new _1();
            var result = t.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
        }

        [TestMethod()]
        public void TwoSumTest2()
        {
            var t = new _1();
            var result = t.TwoSum(new int[] { 3, 2, 4 }, 6);
            CollectionAssert.AreEqual(new int[] { 1, 2 }, result);
        }

        [TestMethod()]
        public void TwoSumTest3()
        {
            var t = new _1();
            var result = t.TwoSum(new int[] { 3, 3 }, 6);
            CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
        }
    }
}