using System;
using Xunit;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest;

// [TestClass]
public class UnitTest1
{
    [Fact]
    public void TestStartsWithUpper()
    {
        // Tests that we expect to return true.
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.True(result,
                   string.Format("Expected for '{0}': true; Actual: {1}",
                                 word, result));
        }
    }

    [Fact]
    public void TestDoesNotStartWithUpper()
    {
        // Tests that we expect to return false.
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.False(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 word, result));
        }
    }

/*
    [Theory]
    [InlineData(string.Empty)]
    [InlineData(null)]
    public void DirectCallWithNullOrEmpty(string value)
    {

        bool result = StringLibrary.StartsWithUpper(value);
        Assert.False(result,
                string.Format("Expected for '{0}': false; Actual: {1}",
                                value == null ? "<null>" : value, result));
        
    }
*/

    [Fact]
    public void DirectCallWithNullOrEmpty()
    {
        // Tests that we expect to return false.
        string?[] words = { string.Empty, null };
        foreach (var word in words)
        {
            bool result = StringLibrary.StartsWithUpper(word);
            Assert.False(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 word == null ? "<null>" : word, result));
        }
    }
}