using System.Collections.Generic;

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
        // TODO: 
        return 0;
    }
}

