using LinkedListStack;
using NUnit.Framework;

namespace Stack.Test.LinkedListStack
{
    public abstract class Base
    {
        #region Setup

        public LinkedListStack<string> PopulatedLinkedListStack { get; set; } 

        public LinkedListStack<string> SingleItemLinkedListStack { get; set; }
        
        public LinkedListStack<string> EmptyLinkedListStack { get; set; }  

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
            PopulatedLinkedListStack = new LinkedListStack<string>();
            foreach (var item in Items)
            {
                PopulatedLinkedListStack.Push(item);
            }
        }

        private void GenerateSingleItemExample()
        {
            SingleItemLinkedListStack = new LinkedListStack<string>();
            SingleItemLinkedListStack.Push(Items[0]);
        }

        private void GenerateEmptyExample()
        {
            EmptyLinkedListStack = new LinkedListStack<string>();
        }

        #endregion
    }
}
