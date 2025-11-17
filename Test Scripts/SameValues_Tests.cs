using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList= new();
        List<int> secondList = new List<int> { 1, 2, 3 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int> { 1, 2, 3 };
        List<int> secondList = new();

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int> { 1, 2, 3 };
        List<int> secondList = new List<int> { 4, 5, 6};

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new List<int> { 12, 14, 13, 16, 17, 19, 20 };
        List<int> secondList = new List<int> { 22, 24, 13, 26, 17, 19, 30 };
        List<int> expected = new List<int> { 13, 17, 19 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}