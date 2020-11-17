# About

Extension methods to convert string arrays to int, double etc.

# Examples

See [the following code](https://github.com/karenpayneoregon/ConverterLibrary/blob/master/Examples/Form1.cs) for Windows Form which of course can be used in other project types.


# Test

```csharp
using System;
using System.Linq;
using ConverterLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class IntTest
    {

        #region int arrays

        /// <summary>
        /// Given a string array of valid int values should convert to int array
        /// </summary>
        [TestMethod]
        public void ConvertAllStringArrayToIntSuccess()
        {
            string[] stringArray = { "2", "4", "6", "8" }; 
            int[] expected = { 2, 4, 6, 8 };

            int[] result = stringArray.ToIntegerArray();

            Assert.IsTrue(result.SequenceEqual(expected));
        }

        /// <summary>
        /// Given a string array of mix types should fail.
        /// </summary>
        [TestMethod]
        public void ConvertAllStringArrayToIntFail()
        {
            string[] stringArray = { "2", "4", "A", "8" };
            int[] expected = { 2, 4, 6, 8 };

            int[] result = stringArray.ToIntegerArray();

            Assert.IsFalse(result.SequenceEqual(expected));
           
        }
        /// <summary>
        /// Given a string array of mix types should return a int array
        /// where each element is an int where those elements not int will
        /// have a value of 0.
        /// </summary>
        [TestMethod]
        public void ConvertStringArrayPreserveSuccess()
        {
            string[] stringArray = { "2", "K", "6", null, "" };
            int[] expected = { 2, 0, 6, 0, 0 };

            int[] result = stringArray.ToIntegerPreserveArray();

            Assert.IsTrue(result.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestAllStringElementsAreIntSuccess()
        {
            string[] stringArray = { "2", "4", "6", "8" };
            Assert.IsTrue(stringArray.AllInt());
        }
        [TestMethod]
        public void TestAllStringElementsAreIntFail()
        {
            string[] stringArray = { "2", "W", "6", null, "true" };
            Assert.IsFalse(stringArray.AllInt());
        }

        #endregion
    }
}
```