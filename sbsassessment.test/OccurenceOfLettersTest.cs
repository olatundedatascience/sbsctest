using NUnit.Framework;
using sbscassessment;
using System;
using System.Collections.Generic;
using System.Text;

namespace sbsassessment.test
{
    [TestFixture]
    public class OccurenceOfLettersTest
    {
        [Test]
        public void TestForLettersOfOccurenceInAString()
        {
            string result = Assessment.numberOfLetterOccurence("olatunde");

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 1);
        }
        [Test]
        public void ShouldReturnTrueIGivenOccurence()
        {
            string result = Assessment.numberOfLetterOccurence("Occurrence");
            Assert.AreEqual(result, "o1c3u1r2e2n1");
        }

        [Test]
        public void ShouldReturnFalseIGivenOlatunde()
        {
            string result = Assessment.numberOfLetterOccurence("Olatunde");
            bool falseyResult = result != "02l1a1t1u2n1d1e1";
            Assert.IsTrue(falseyResult);
            
        }
    }
}
