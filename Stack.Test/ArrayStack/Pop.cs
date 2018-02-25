using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Stack.Test.ArrayStack
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
            Assert.Throws<IndexOutOfRangeException>(() => EmptyArrayStack.Pop());
        }

        // Test: Use Pop() to remove and return an item from a single item stack
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should equal 0
        [Test]
        public void PopFromSingleItemStack()
        {
            Assert.That(SingleItemArrayStack.Pop(), Is.EqualTo(Items[0]));
            Assert.That(SingleItemArrayStack.Count, Is.EqualTo(0));
        }

        // Test: Use Pop() to remove and return an item from a populated stack
        // Outcome:
        // 1. Value returned should equal items[9] "That"
        // 2. Count should equal items - 1
        [Test]
        public void PopFromPopulatedStack()
        {
            Assert.That(PopulatedArrayStack.Pop(), Is.EqualTo(Items[9]));
            Assert.That(PopulatedArrayStack.Count, Is.EqualTo(Items.Length - 1));
        }
    }
}
