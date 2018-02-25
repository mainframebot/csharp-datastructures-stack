using ArrayStack;
using NUnit.Framework;

namespace Stack.Test.ArrayStack
{
    public abstract class Base
    {
        #region Setup

        public ArrayStack<string> PopulatedArrayStack { get; set; }

        public ArrayStack<string> SingleItemArrayStack { get; set; }

        public ArrayStack<string> EmptyArrayStack { get; set; }

        public string[] Items = { "I am", "Sorry", "Dave", ",", "I'm", "Afraid", "I", "Can't", "Do", "That" };

        public string Item = "Robot";

        [SetUp]
        public void BeforeEachTest()
        {
            GeneratePopulatedExample();
            GenerateSingleItemExample();
            GenerateEmptyExample();
        }

        #endregion

        #region Private Methods

        private void GeneratePopulatedExample()
        {
            PopulatedArrayStack = new ArrayStack<string>();
            foreach (var item in Items)
            {
                PopulatedArrayStack.Push(item);
            }
        }

        private void GenerateSingleItemExample()
        {
            SingleItemArrayStack = new ArrayStack<string>();
            SingleItemArrayStack.Push(Items[0]);
        }

        private void GenerateEmptyExample()
        {
            EmptyArrayStack = new ArrayStack<string>();
        }

        #endregion
    }
}
