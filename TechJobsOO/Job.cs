using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors. ✅
        public Job()
        {
            Id = nextId;
            //int id = nextId;
            nextId++;
        }
        // TODO: Generate Equals() and GetHashCode() methods. ✅
        public Job(string name) : this() { Name = name; }

        //TODO: Each Job object should contain six properties—Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency.
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this() 
        { 
            Name = name; 
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        static string GetName<T>(T item) where T : class
        {
            return typeof(T).GetProperties()[0].Name;
        }
        public override string ToString()
        {
            //string output = "ID: \nName: \nEmployer: \nLocation: \nPostion Type: \nCore Competency: ";
            string output = "";
            //foreach(var property in typeof(Job).GetProperties())
            //{
            //    if (property != null)
            //    {
            //        output += $"{property.GetAccessors(true)}\n";
            //    }
            //}

            List<JobField> arguments = new List<JobField>();
            //arguments.Add(Id);
            //arguments.Add(Name);
            arguments.Add(EmployerName);
            arguments.Add(EmployerLocation);
            arguments.Add(JobType);
            arguments.Add(JobCoreCompetency);
            //.Actual:< Int32: 3 String: Product tester Employer: ACME Location: Desert PositionType: Quality control CoreCompetency: Persistence >.
            output += $"\nID: {Id}\n";

            if(Name != "")
            {
                output += $"Name: {Name}\n";

            }
            else
            {
                output += $"Name: Data not available\n";
            }
            foreach (JobField arg in arguments)
            {


                if (arg != null && arg.Value != "")
                {
                    if (arg.GetType().Name == "Employer")
                    {
                        output += $"Employer: {arg.Value}\n";
                    }
                    if (arg.GetType().Name == "Location")
                    {
                        output += $"Location: {arg.Value}\n";
                    }
                    if (arg.GetType().Name == "PositionType")
                    {
                        output += $"Position Type: {arg.Value}\n";
                    }
                    if (arg.GetType().Name == "CoreCompetency")
                    {
                        output += $"Core Competency: {arg.Value}\n";
                    }
                }
                else
                {
                    if (arg.GetType().Name == "Employer")
                    {
                        output += $"Employer: Data not available\n";
                    }
                    if (arg.GetType().Name == "Location")
                    {
                        output += $"Location: Data not available\n";
                    }
                    if (arg.GetType().Name == "PositionType")
                    {
                        output += $"Position Type: Data not available\n";
                    }
                    if (arg.GetType().Name == "CoreCompetency")
                    {
                        output += $"Core Competency: Data not available\n";
                    }
                }
            }
            return output;
        }
    }
}
