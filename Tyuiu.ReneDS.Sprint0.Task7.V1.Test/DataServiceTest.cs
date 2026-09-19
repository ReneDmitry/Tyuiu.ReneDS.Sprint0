using Tyuiu.ReneDS.Sprint0.Task7.V1.Lib;

namespace Tyuiu.ReneDS.Sprint0.Task7.V1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1, };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1, };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2, };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}