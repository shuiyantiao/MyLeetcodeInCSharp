using System.Text;

using static AnswerLib._1_100._2;

namespace AnswerLib._1_100.Tests
{
    [TestClass()]
    public class _2Tests
    {
        private string ListNodeToString(ListNode node)
        {
            var sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.val.ToString());
                node = node.next;
            }
            return sb.ToString();
        }

        [TestMethod()]
        public void AddTwoNumbersTest1()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var _2 = new _2();
            var result = _2.AddTwoNumbers(l1, l2);
            Assert.AreEqual(ListNodeToString(result), "708");
        }

        [TestMethod()]
        public void AddTwoNumbersTest2()
        {
            var l1 = new ListNode(5);
            var l2 = new ListNode(5);

            var _2 = new _2();
            var result = _2.AddTwoNumbers(l1, l2);
            Assert.AreEqual(ListNodeToString(result), "01");
        }

        [TestMethod()]
        public void AddTwoNumbersTest3()
        {
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9)));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))));
            var _2 = new _2();
            var result = _2.AddTwoNumbers(l1, l2);
            Assert.AreEqual(ListNodeToString(result), "8990001");
        }
    }
}