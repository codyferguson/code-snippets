using System;
using System.Diagnostics.Tracing;

namespace csharp; 
public class Interview {


    public Interview() {
    }

    static void Main(string[] args) {
        Interview interview = new Interview();

        //string answer = interview.ReversedString("hello world");

        Console.WriteLine("Hello");
    }

    public string ReversedString(string word) {
        char[] reversedString = new char[word.Length];

        int wordIndex = word.Length;
        for (int i = 0; i < word.Length - 1; i++) {
            reversedString[i] = word[wordIndex];
            wordIndex--;
        }

        return reversedString.ToString();
    }
}
