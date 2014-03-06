using System;
using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.StringStackTest
{
    [TestFixture]
    public class WhenPush
    {
        [Test]
        public void IfPushHolaThenStackShouldContainNumberHolaAtTop()
        {
            var stack = new Stack<String>(1);
            stack.Push("Hola");
            Assert.AreEqual(stack.Top(), "Hola");
        }

        [Test]
        public void IfPushHolaTenAndMundoThenStackShouldContainHolaAtTop()
        {
            var stack = new Stack<String>(1);
            stack.Push("Hola");
            Assert.AreEqual("Hola", stack.Top());
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowInvalidOperationExceptionIfCapacityIsOverloaded()
        {
            var stack = new Stack<String>(2);
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
        }
    }
}
