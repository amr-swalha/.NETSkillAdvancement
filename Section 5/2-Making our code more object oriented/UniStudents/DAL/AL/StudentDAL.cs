
using DAL.Models;

namespace DAL.AL
{
    public class StudentDAL
    {
        DB<Student> _db = new DB<Student>();
        public int Add(Student student)
        {
            _db.Add(student);
            return 1;
        }
    }
}
