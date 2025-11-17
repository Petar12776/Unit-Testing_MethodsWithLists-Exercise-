using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> emptyList = new();
        int threshold = 3;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(emptyList, threshold);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> emptyList = new List<int> { 13, 15, 17, 19, 21, 23};
        int threshold = 10;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(emptyList, threshold);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> emptyList = new List<int> { 1, 2, 3, 4, 5, 6 };
        int threshold = 10;
        List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(emptyList, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> emptyList = new List<int> { 1, 2, 3, 4, 5, 6, 12, 14, 16, 18, 20 };
        int threshold = 10;
        List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(emptyList, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
