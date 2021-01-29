using Cw4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw4.Services
{
    interface IStudentDbInterface
    {
        List<Student> getStudentsFromDb();
        Semester getSemester(string id);
    }
}
