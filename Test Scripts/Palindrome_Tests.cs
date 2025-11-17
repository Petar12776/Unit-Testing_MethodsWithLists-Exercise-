using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> validPalindrome = new List<string>() { "level", "madam", "civic" };
        bool expected = true; 

        // Act
        bool result = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emptyList = new List<string>();
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(emptyList);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> validPalindrome = new List<string>() { "radar" };
        bool expected = true;
        
        // Act
        bool result = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> validPalindrome = new List<string>() { "phone" };
        bool expected = false;

        // Act
        bool result = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> validPalindrome = new List<string>() { "Level", "Madam", "Civic" };
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
