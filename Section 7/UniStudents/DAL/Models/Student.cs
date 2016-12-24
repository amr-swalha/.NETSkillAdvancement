using System;

namespace DAL.Models
{
    public class Student : Data
    {
        public int ID
        {
            get;
            set;
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
