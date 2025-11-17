using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> numbers = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 25, 81 };
        List<int> expected = new List<int> { 1, 5, 9 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(numbers);
        
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> numbers = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> emptyList = new();
        
        // Act
        List<double> result = NumberProcessor.ProcessNumbers(emptyList);

        // Assert
        CollectionAssert.IsEmpty(result);
    }
}