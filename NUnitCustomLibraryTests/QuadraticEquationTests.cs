using NUnit.Framework;
using QuadraticEquation;
using System;

namespace NUnitCustomLibraryTests
{
    public class QuadraticEquationTests
    {
        private QuadraticEquationService _quadraticEquationService;
        [SetUp]
        public void Setup()
        {
            _quadraticEquationService = new QuadraticEquationService();
        }

        [TestCase(2, 5, -7, new double[] { -3.5, 1 })]
        [TestCase(1, 3, -4, new double[] { -4, 1 })]
        public void GetRoots_TwoRootsCase_MatchExpectedResult(double a, double b, double c, double[] expectedResult)
        {
            var actualResult = _quadraticEquationService.GetRoots(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 6, 9, new double[] { -3, 0 })]
        [TestCase(16, -8, 1, new double[] { 0.25, 0 })]
        public void GetRoots_OneRootCase_MatchExpectedResult(double a, double b, double c, double[] expectedResult)
        {
            var actualResult = _quadraticEquationService.GetRoots(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, -8, 72, new double[] { 0, 0 })]
        [TestCase(9, -6, 2, new double[] { 0, 0 })]
        public void GetRoots_NoRootsCase_ZeroValues(double a, double b, double c, double[] expectedResult)
        {
            var actualResult = _quadraticEquationService.GetRoots(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(double.MaxValue, 5, 7, new double[] { 0, 0 })]
        [TestCase(double.MinValue, 5, 7, new double[] { double.NaN, double.NaN })]
        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue, new double[] { double.NaN, double.NaN })]
        [TestCase(double.MinValue, double.MinValue, double.MinValue, new double[] { double.NaN, double.NaN })]
        public void GetRoots_EdgeCases_MatchExpectedResult(double a, double b, double c, double[] expectedResult)
        {
            var actualResult = _quadraticEquationService.GetRoots(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(4, 0, -64, new double[] { -4, 4 })]
        [TestCase(64, 4, 0, new double[] { -0.0625, 0 })]
        [TestCase(4, 0, 0, new double[] { 0, 0 })]
        public void GetRoots_IncompleteEquationCase_MatchExpectedResult(double a, double b, double c, double[] expectedResult)
        {
            var actualResult = _quadraticEquationService.GetRoots(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetRoots_FirstCoefficientIsZero_ThowExeption()
        {
            Assert.Throws<InvalidOperationException>(() => _quadraticEquationService.GetRoots(0, 5, 8));
        }

        [Test]
        public void IsNotZero_0_False()
        {
            var a = 0;

            var actualResult = _quadraticEquationService.IsNotZero(a);

            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsNotZero_5_True()
        {
            var a = 5;

            var actualResult = _quadraticEquationService.IsNotZero(a);

            Assert.IsTrue(actualResult);
        }

    }
}