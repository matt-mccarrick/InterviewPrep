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
    public class PermutationCheckerTests
    {
        [TestMethod()]
        public void IsPermutationTest()
        {
            var test = new PermutationChecker();
            Assert.IsTrue(test.IsPermutation("dog", "god"));
            Assert.IsFalse(test.IsPermutation("blah", "notblah"));
        }
    }
}