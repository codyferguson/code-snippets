using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace csharp.GrokkingAlgorithms; 
public class ScratchPadForProblems {

    public int Sum(int[] numbers) {
        if (numbers == null || numbers.Length == 0) return 0;

        return numbers[0] + Sum(numbers[1..numbers.Length]);
    }

    public int CountItemsInList(List<int> items) {
        if (items == null || items.Count == 0) return 0;

        return 1 + CountItemsInList(items.GetRange(1, items.Count - 1));

    }

    public int MaxNumberInList(List<int> numbers) {

        if (numbers.Count == 1) return numbers[0];

        if (numbers.Count == 2) {
            return (numbers[0] >= numbers[1]) ? numbers[0] : numbers[1];
        } else {
            int left = MaxNumberInList(numbers);
            int right = MaxNumberInList(numbers);
            return left >= right ? left : right;
        }
    }
}

