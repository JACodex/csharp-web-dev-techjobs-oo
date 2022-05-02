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

        [TestMethod] //TODO: Each Job object should contain six properties—Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency. ✅
        public void TechjobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.JobType.Value == "Quality control");
            Assert.IsTrue(job1.JobCoreCompetency.value == "Persistence");
        }

        [TestMethod] //TODO: Two Job objects are considered equal if they have the same id value, even if one or more of the other fields differ || should return False only if id != id ✅
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse (job1.Equals(job2));
        }


    }
}