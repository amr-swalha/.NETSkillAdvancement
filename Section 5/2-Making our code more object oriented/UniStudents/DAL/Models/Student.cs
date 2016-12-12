using System;

namespace DAL.Models
{
    public class Student  :Data
    {
        public int ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Profile profile { get; set; }
        enum StudentStatus
        {
            isActive,
            isHavingBalance,
            isNotCommited
        }
    }
}
