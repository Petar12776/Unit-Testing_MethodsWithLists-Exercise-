using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> emptyList = new();
        List<int> emptyEvenList = new();
        List<int> emptyOddList = new();

        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(emptyList);

        // Assert
        Assert.AreEqual(emptyEvenList, evenResult);
        Assert.AreEqual(emptyOddList, oddResult);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> list = new List<int> { 2, 4 };
        List<int> evenList = new List<int> { 2, 4 };
        List<int> emptyOddList = new();

        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(list);

        // Assert
        Assert.AreEqual(evenList, evenResult);
        Assert.AreEqual(emptyOddList, oddResult);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> list = new List<int> { 1, 3 };
        List<int> emptyEvenList = new();
        List<int> oddList = new List<int> { 1, 3 };

        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(list);

        // Assert
        Assert.AreEqual(emptyEvenList, evenResult);
        Assert.AreEqual(oddList, oddResult);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4 };
        List<int> evenList = new List<int> { 2, 4 };
        List<int> oddList = new List<int> { 1, 3};

        // Act
        (List<int> evenResult, List<int> oddResult) = ListSplitter.SplitEvenAndOdd(list);

        // Assert
        Assert.AreEqual(evenList, evenResult);
        Assert.AreEqual(oddList, oddResult);
    }
}