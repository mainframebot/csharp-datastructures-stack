using System;
using NUnit.Framework;

namespace Stack.Test.LinkedListStack
{
    [TestFixture]
    public class Peek : Base
    {
        // Test: Use Peek() to view the top item of an empty stack
        // Outcome:
        // 1. IndexOutOfRangeException should be thrown
        [Test]
        public void PeekEmptyStack()
        {
            Assert.Throws<IndexOutOfRangeException>(() => EmptyLinkedListStack.Peek());
        }

        // Test: Use Peek() to view the top item of a single item stack
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should remain unchanged
        [Test]
        public void PeekSingleItemStack()
        {
            Assert.That(SingleItemLinkedListStack.Peek(), Is.EqualTo(Items[0]));
            Assert.That(SingleItemLinkedListStack.Count, Is.EqualTo(1));
        }

        // Test: Use Peek() to view the top item of a populated stack
        // Outcome:
        // 1. Value returned should equal items[9] "That"
        // 2. Count should remain unchanged
        [Test]
        public void PeekPopulatedStack()
        {
            Assert.That(PopulatedLinkedListStack.Peek(), Is.EqualTo(Items[9]));
            Assert.That(PopulatedLinkedListStack.Count, Is.EqualTo(Items.Length));
        }
    }
}
