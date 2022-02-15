using MediatR;
using StudentManagement.API.Data;
using StudentManagement.API.Library.Commands;
using StudentManagement.API.Model;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.API.Library.Handlers
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, StudentModel>
    {
        private readonly IDataAccess _dataAccess; 
        public AddStudentHandler(IDataAccess dataAccess)
        {
                _dataAccess = dataAccess;
        }
        public Task<StudentModel> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            // phat event cho message broker ( message bus: rabbit, active, kafa, ram )

            return Task.FromResult(_dataAccess.AddStudent(request.FirstName,request.LastName));
        }
    }
}
