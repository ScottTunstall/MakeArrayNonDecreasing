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


        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = {4, 5, 7, 7, 13};

            var totalSteps = _sut.TotalSteps(nums);

            Assert.AreEqual(0, totalSteps);

        }



        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = {10, 1, 2, 3, 4, 5, 6, 1, 2, 3};

            var totalSteps = _sut.TotalSteps(nums);

            Assert.AreEqual(6, totalSteps);
        }



    }
}