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
        [TestCase(6)]
        public void CheckStudentIdUpdate(int id)
        {

            Assert.AreEqual(objStudent.ID, id);
        }

        [SetUp]
        public void SetupThevalueofstudent()
        {
            objStudent.ID = 6;
        }
    }
}
