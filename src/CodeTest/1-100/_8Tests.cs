namespace AnswerLib._1_100.Tests
{
    [TestClass()]
    public class _8Tests
    {
        [TestMethod()]
        public void MyAtoiTest1()
        {
            var _8 = new _8();
            var result = _8.MyAtoi("42");
            Assert.AreEqual(result, 42);
        }

        [TestMethod()]
        public void MyAtoiTest2()
        {
            var _8 = new _8();
            var result = _8.MyAtoi("   -42");
            Assert.AreEqual(result, -42);
        }

        [TestMethod()]
        public void MyAtoiTest3()
        {
            var _8 = new _8();
            var result = _8.MyAtoi("4193 with words");
            Assert.AreEqual(result, 4193);
        }
    }
}