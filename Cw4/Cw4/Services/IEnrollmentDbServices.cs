using Cw4.Requests;
using Cw4.Response;

namespace Cw4.Services
{
    public interface IEnrollmentDbServices
    {
        EnrollStudentResponse EnrollStudent(EnrollStudentRequest request);

        PromoteStudentsResponse PromoteStudents(PromoteStudentRequest request);
    }

}
