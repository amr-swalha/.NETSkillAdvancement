using BL;
using DAL.Models;

namespace ConsoleData
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBL student = new StudentBL();
            Profile profile = new Profile();
            profile.Email = "test";
            profile.FullName = "test";
            student.AddStudent(new Student() { profile = profile});
        }
    }
}
