using csharp.GrokkingAlgorithms;

namespace csharpTests.GrokkingAlgorithms;

[TestFixture]
public class ScratchPadForProblemsTests {
    private ScratchPadForProblems _scratchPadForProblems;

    [SetUp]
    public void SetUp() {
        _scratchPadForProblems = new ScratchPadForProblems();
    }

    [TestCase(new int[] { 1 }, ExpectedResult = 1)]
    [TestCase(new int[] { 1, 2 }, ExpectedResult = 3)]
    [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 6)]
    [TestCase(new int[] { 4, 5, 6, 9, 1, 7 }, ExpectedResult = 32)]
    public int ScratchPadForProblems_ValidateSum(int[] numbers) {
        return _scratchPadForProblems.Sum(numbers);
    }

    [TestCase(new int[] { 1 }, ExpectedResult = 1)]
    [TestCase(new int[] {1, 2, 3, 4}, ExpectedResult = 4)]
    public int ScratchPadForProblems_ValidateCountItemsInList(int[] items) {
        List<int> numbers = items.ToList();
        return _scratchPadForProblems.CountItemsInList(numbers);
    }

    [TestCase(new int[] {3}, ExpectedResult = 3)]
    [TestCase(new int[] {5, 3, 1, 2}, ExpectedResult = 5)]
    [TestCase(new int[] { -1, 6, 1, 11}, ExpectedResult = 11)]
    public int ScratchPadForProblems_ValidLists_ShouldReturnExpectedResult(int[] items) {
        List<int> numbers = items.ToList();
        return _scratchPadForProblems.MaxNumberInList(numbers);
    }
}
