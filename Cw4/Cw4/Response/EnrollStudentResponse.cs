using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw4.Response
{
    public class EnrollStudentResponse
    {
        public string LastName { get; set; }
        public int Semester { get; set; }
        public string StartDate { get; set; }
        public string Studies { get; set; }
    }
}
}