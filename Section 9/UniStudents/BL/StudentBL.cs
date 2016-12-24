using DAL.AL;
using DAL.Models;

namespace BL
{
    public class StudentBL
    {
        StudentDAL studentDAL = new StudentDAL();
        public void AddStudent(Student student)
        {
            studentDAL.Add(student);
        }
    }
}
