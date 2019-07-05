using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringsProblem
{
    [TestFixture]
    class UnitTest
    {
        [TestCase("dc-ba", "ab-cd")]
        [TestCase("j-Ih-gfE-dCba", "a-bC-dEf-ghIj")]
        [TestCase("Qedo1ct-eeLg=ntse-T!", "Test1ng-Leet=code-Q!")]
        public void TestRev(string expected, string S)
        {
            Assert.AreEqual(expected, Solution.ReverseLetters(S));
        }

        [TestCase("")]
        public void TestRev(string S)
        {
            Assert.Throws<InvalidOperationException>(() => Solution.ReverseLetters(S));
        }
    }
}
