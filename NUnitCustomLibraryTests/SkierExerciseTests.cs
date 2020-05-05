using System;
using System.Collections;
using NUnit.Framework;
using SkierExercise;

namespace NUnitCustomLibraryTests
{
    public class SkierExerciseTests
    {
        private DaysTraker _daysTraker;
        [SetUp]
        public void Setup()
        {
            _daysTraker = new DaysTraker();
        }

        [TestCase(500)]
        [TestCase(0)]
        public void IsValidPercentInput_PositiveOrZero_True(double input) 
        {
            var actualResult = _daysTraker.IsValidPercentInput(input);

            Assert.IsTrue(actualResult);
        }

        [TestCase(-80)]
        [TestCase(-9000)]
        public void IsValidPercentInput_NegativeInput_False(double input)
        {
            var actualResult = _daysTraker.IsValidPercentInput(input);

            Assert.IsFalse(actualResult);
        }

        [TestCase(50, 500)]
        [TestCase(10, 70)]
        public void IsValidDistance_ValidInput_True(double input1, double input2)
        {
            var actualResult = _daysTraker.IsValidDistance(input1, input2);

            Assert.IsTrue(actualResult);
        }

        [TestCase(-900, 500)]
        [TestCase(900, -500)]
        [TestCase(-900, -500)]
        public void IsValidDistance_NegativeInput_False(double input1, double input2)
        {
            var actualResult = _daysTraker.IsValidDistance(input1, input2);

            Assert.IsFalse(actualResult);
        }

        [TestCase(0, 500)]
        [TestCase(900, 0)]
        [TestCase(0, 0)]
        public void IsValidDistance_ZeroInput_False(double input1, double input2)
        {
            var actualResult = _daysTraker.IsValidDistance(input1, input2);

            Assert.IsFalse(actualResult);
        }

        [TestCase(10000, 500)]
        public void IsValidDistance_InitialBiggerThanTotal_False(double input1, double input2)
        {
            var actualResult = _daysTraker.IsValidDistance(input1, input2);

            Assert.IsFalse(actualResult);
        }

        [Test]
        public void GetFinalDay_ValidInput_MatchExpectedResult() 
        {
            double initialDistance = 50;
            double percentageIncrease = 10;
            double totalDistance = 500;
            var expectedResult = 15;
            var actualResult = _daysTraker.GetFinalDay(initialDistance, percentageIncrease, totalDistance);

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestCase(0, 5, 0, 0)] // distance == 0
        //[TestCase(10, -5, 50, 0)] // if distance increase percent is negative
        //[TestCase(50, 5, 5, 0)] // initial distance bigger than planned distance 
        //[TestCase(-10, -8, -50, 0)] // negative values 
        //[TestCase(0, 0, 0, 0)] // zero values



        [Test, TestCaseSource(typeof(MyFactoryClass), "TestCases")]
        public double GetFinalDay_InvalidInput_Zero(double a, double b, double c) 
        {
            return _daysTraker.GetFinalDay(a, b, c);

        }

        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue,  3 )]
        [TestCase(double.MinValue, double.MinValue, double.MinValue, 0)]
        public void GetFinalDay_EdgeCases_MatchExpectedResult(double a, double b, double c, double expectedResult)
        {
            var actualResult = _daysTraker.GetFinalDay(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }

    public class MyFactoryClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(0, 5, 0).Returns(0);
                yield return new TestCaseData(10, -5, 50).Returns(0);
                yield return new TestCaseData(50, 5, 5).Returns(0);
                yield return new TestCaseData(-10, -8, -50).Returns(0);
                yield return new TestCaseData(0, 0, 0).Returns(0);
            }
        }
    }
}
