using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
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
    }
}