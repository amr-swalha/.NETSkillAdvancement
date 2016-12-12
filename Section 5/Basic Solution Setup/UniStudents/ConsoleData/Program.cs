using BL;
using DAL.Models;

namespace ConsoleData
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBL student = new StudentBL();
            student.AddStudent(new Student() { FullName = "Test", Email = "test@test.com" });
        }
    }
}
