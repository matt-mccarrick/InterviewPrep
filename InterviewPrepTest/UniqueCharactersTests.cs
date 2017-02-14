using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewPrep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Tests
{
    [TestClass()]
    public class UniqueCharactersTests
    {
        [TestMethod()]
        public void HasUniqueCharactersExternalDataTest()
        {
            var test = new UniqueCharacters();
            Assert.IsTrue(test.HasUniqueCharactersExternalData(null));
            Assert.IsTrue(test.HasUniqueCharactersExternalData("cat"));
            Assert.IsTrue(test.HasUniqueCharactersExternalData(""));
            Assert.IsTrue(test.HasUniqueCharactersExternalData("blahdtyu"));
            Assert.IsFalse(test.HasUniqueCharactersExternalData("cata"));
            Assert.IsFalse(test.HasUniqueCharactersExternalData("aa"));
        }

        [TestMethod()]
        public void HasUniqueCharactersInPlaceTest()
        {
            var test = new UniqueCharacters();
            Assert.IsTrue(test.HasUniqueCharactersInPlace(null));
            Assert.IsTrue(test.HasUniqueCharactersInPlace("cat"));
            Assert.IsTrue(test.HasUniqueCharactersInPlace(""));
            Assert.IsTrue(test.HasUniqueCharactersInPlace("blahdtyu"));
            Assert.IsFalse(test.HasUniqueCharactersInPlace("cata"));
            Assert.IsFalse(test.HasUniqueCharactersInPlace("aa"));
        }
    }
}