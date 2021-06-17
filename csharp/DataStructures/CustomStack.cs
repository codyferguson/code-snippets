using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class CustomStack
    {
        private int lastElement;
        private string[] stackArray;
        private int stackSize;

        public CustomStack(int size) {
            stackSize = size;
            stackArray = new string[stackSize];
            lastElement = 0;
        }

        public void Push(string element) {
            if (lastElement + 1 == stackSize) {
                // double array size
            }
            stackArray[lastElement++] = element;
        }

        public string Pop() {
            string element = "empty";

            if (lastElement > -1) {
                element = stackArray[lastElement--];
            }

            return element;
        }

        public string Peak() {
            string element = "empty";

            if (lastElement > -1) {
                element = stackArray[lastElement];
            }

            return element;
        }

        private 
    }
}
