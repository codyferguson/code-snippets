using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.DataStructures;

// Practice writing a simple queue. may add to it later for practice
public class CustomQueue
{
    private int add;
    private int remove;
    private int queueSize;
    private string[] queueArray;

    public CustomQueue(int size) {
        add = 0;
        remove = 0;
        queueSize = size;
        queueArray = new string[size];
    }

    public void Enqueue(string element) {
        if (queueArray.Length < queueSize) {
            queueArray[add++] = element;
        } else {
            queueArray = DoubleArraySize(queueArray);
        }
    }

    public string Dequeue() {
        if (queueArray.Length != 0) {
            string item = queueArray[remove--];
            remove = remove >= queueSize ? 0 : remove;
            return item;
        }
        return "empty";
    }

    // Copies old array into array double it's size
    // data added to front of the array and pointers reset
    private string[] DoubleArraySize(string[] oldArray) {
        int oldSize = queueSize;
        queueSize = queueSize << 1;
        string[] newArr = new string[queueSize];
        for (int i = 0; i < oldSize; i++) {
            newArr[i] = Dequeue();
        }

        return newArr;
    }
}
