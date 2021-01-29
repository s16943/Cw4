using Cw4.Requests;
using Cw4.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw4.Services
{

    public interface IEnrollmentDbServices
    {
        EnrollStudentResponse EnrollStudent(EnrollStudentRequest request);

        PromoteStudentsResponse PromoteStudents(PromoteStudentRequest request);
    }

}
