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
    public class OneAwayTests
    {
        [TestMethod()]
        public void IsOneAwayTest()
        {
            var test = new OneAway();
            Assert.IsTrue(test.IsOneAway("bat", "cat"));
            Assert.IsTrue(test.IsOneAway("bate", "bat"));
            Assert.IsTrue(test.IsOneAway("bat", "bate"));
            Assert.IsFalse(test.IsOneAway("bat", "cate"));
        }
    }
}