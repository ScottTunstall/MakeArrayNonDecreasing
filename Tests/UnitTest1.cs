using MakeArrayNonDecreasing;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Solution? _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new Solution();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = {5, 3, 4, 4, 7, 3, 6, 11, 8, 5, 11};

            var totalSteps = _sut.TotalSteps(nums);

            Assert.AreEqual(3, totalSteps);
        }
    }
}