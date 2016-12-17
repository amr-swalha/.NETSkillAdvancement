using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL.Models;

namespace UniStudents.Tests
{
    [TestFixture]
    public class StudentTests
    {
        Student objStudent = new Student();
        [Test]
        public void CheckStudent()
        {
            Student student = new Student();
            student.ID = 1;
            Assert.AreEqual(student.ID, 1);
        }
        [Retry(2)] //Will retry in case of failure
        [TestCase(6)]
        public void CheckStudentIdUpdate(int id)
        {

            Assert.AreEqual(objStudent.ID, id);
        }
        [Repeat(3)] //Will repeat the method
        [Test]
        public void CheckRetry()
        {

        }
        [Order(3)]//Will set the order of running test
        [Test]
        public void CheckOrder()
        {

        }
        [Ignore("not ok")] //To ignore the test, make sure you pass string of the reason
        [Test]
        public void CheckIgnore()
        {

        }
        [SetUp] //Will be called in before any other test method to setup values
        public void SetupThevalueofstudent()
        {
            objStudent.ID = 6;
        }
    }
}
