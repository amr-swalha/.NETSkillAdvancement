using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface Data
    {
        int ID { get; set; }
        Profile profile { get; set; }
    }
}
