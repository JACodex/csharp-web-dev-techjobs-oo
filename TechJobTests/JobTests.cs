using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void JobNameTest() // Should Assert That an instance of a jobs constructor is properly initialized
        {
            Job job1 = new Job("Product tester");
            Assert.AreEqual("Product tester", job1.Name);
        }

        [TestMethod]  // Should Assert That Job n no arg constructor initializes an Id ✅
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Equals(job2));
        }
    }
}