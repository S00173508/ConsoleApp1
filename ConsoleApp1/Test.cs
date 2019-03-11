using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InsuranceService
{
    [TestFixture]
    class Test_InsuranceService
    {
        InsuranceService sut;

        [SetUp]
        public void Initialized()
        {
            sut = new InsuranceService();
        }
 
        [TestCase(25, "female", ExpectedResult = 5.0f)]
        [TestCase(33, "female", ExpectedResult = 3.5f)]
        [TestCase(67, "female", ExpectedResult = 1.75f)]
        [TestCase(16, "female", ExpectedResult = 0.0f)]
        [TestCase(21, "male", ExpectedResult = 6.0f)]
        [TestCase(39, "male", ExpectedResult = 5.0f)]
        [TestCase(72, "male", ExpectedResult = 2.5f)]
        [TestCase(17, "male", ExpectedResult = 0.0f)]

        public float Test_CalcPremium_many(int a, string b)
        {
            float actualResult = sut.CalcPremium(a, b);
            // Assert.That(actualResult, Is.EqualTo(1.75f));
            return actualResult;
        }
    }
}