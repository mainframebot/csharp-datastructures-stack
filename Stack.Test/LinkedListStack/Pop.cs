using System;
using NUnit.Framework;

namespace Stack.Test.LinkedListStack
{
    [TestFixture]
    public class Pop : Base
    {
        // Test: Use Pop() to remove and return an item from an empty stack
        // Outcome:
        // 1. IndexOutOfRangeException should be thrown
        [Test]
        public void PopFromEmptyStack()
        {
            Assert.Throws<IndexOutOfRangeException>(() => EmptyLinkedListStack.Pop());
        }

        // Test: Use Pop() to remove and return an item from a single item stack
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should equal 0
        [Test]
        public void PopFromSingleItemStack()
        {
            Assert.That(SingleItemLinkedListStack.Pop(), Is.EqualTo(Items[0]));
            Assert.That(SingleItemLinkedListStack.Count, Is.EqualTo(0));
        }

        // Test: Use Pop() to remove and return an item from a populated stack
        // Outcome:
        // 1. Value returned should equal items[9] "That"
        // 2. Count should equal items - 1
        [Test]
        public void PopFromPopulatedStack()
        {
            Assert.That(PopulatedLinkedListStack.Pop(), Is.EqualTo(Items[9]));
            Assert.That(PopulatedLinkedListStack.Count, Is.EqualTo(Items.Length - 1));
        }
    }
}
