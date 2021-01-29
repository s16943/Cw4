using Cw4.Models;
using System.Collections.Generic;

namespace Cw4.Services
{
    interface IStudentDbInterface
    {
        List<Student> GetStudentsFromDb();
        Semester GetSemester(string id);

        bool TrueStudent(string indexNumber);
    }
}
