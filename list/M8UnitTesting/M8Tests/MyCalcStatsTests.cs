using NUnit.Framework;
using M8Project;

namespace M8Tests
{
    public class Tests
    {
        private MyCalcStats myCalc;

        [SetUp]
        public void Setup()
        {
            int[] nums = { 6, 9, 15, -2, 92, 11 };
            myCalc = new MyCalcStats(nums);
        }

        [Test]
        public void CalcStatsTest_GetMininum()
        {
            Assert.AreEqual(-2, myCalc.GetMininum());
        }

        [Test]
        public void CalcStatsTest_GetMaximum()
        {
            Assert.AreEqual(92, myCalc.GetMaximum());
        }

        [Test]
        public void CalcStatsTest_Fails_GetAverageReturnsValue()
        {
            Assert.AreNotEqual(18.166666, myCalc.GetAverage());
        }

        [Test]
        public void CalcStatsTest_GetAverageReturnsValue()
        {
            Assert.AreEqual(21.833333333333332, myCalc.GetAverage());
        }

        [Test]
        public void CalcStatsTest_Count_Returns6()
        {
            Assert.AreEqual(6, myCalc.Count());
        }
    }
}
