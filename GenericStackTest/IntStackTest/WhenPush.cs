using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.IntStackTest
{
    [TestFixture]
    public class WhenPush
    {
        [Test]
        public void IfPushNumberTwoThenStackShouldContainNumberTwoAtTop()
        {
            var stack = new IntStack();
            stack.Push(2);
            Assert.AreEqual(stack.Top(), 2);
        }

        [Test]
        public void IfPushNumberTenAndThreeThenStackShouldContaintNumberThreeAtTop()
        {
            var stack = new IntStack();
            stack.Push(10);
            stack.Push(3);
            Assert.AreEqual(stack.Top(), 3);
        }
    }
}
