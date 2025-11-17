using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> emptyList = new();
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(emptyList, threshold);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> emptyList = new List<int> { 11, 13, 15, 17, 19, 20};
        int threshold = 20;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(emptyList, threshold);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> emptyList = new List<int> { 21, 23, 25, 27, 29, 30 };
        int threshold = 20;
        List<int> expected = new List<int> { 21, 23, 25, 27, 29, 30 };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(emptyList, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> emptyList = new List<int> { 12, 14, 16, 18, 19, 20, 21, 24, 25, 26, 28, 29, 30 };
        int threshold = 20;
        List<int> expected = new List<int> { 21, 24, 25, 26, 28, 29, 30 };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(emptyList, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
