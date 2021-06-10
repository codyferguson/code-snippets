
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

    public void push(string element) {
        if (lastElement + 1 == stackSize) {
            // double array size
        }
        stackArray[lastElement++] = element;
    }

    public string pop() {
        string element = "empty";

        if(lastElement > -1) {
            element = stackArray[lastElement--];
        }

        return element
    }

    public string peak() {
        string element = "empty";

        if (lastElement > -1) {
            element = stackArray[lastElement];
        }

        return element
    }
}