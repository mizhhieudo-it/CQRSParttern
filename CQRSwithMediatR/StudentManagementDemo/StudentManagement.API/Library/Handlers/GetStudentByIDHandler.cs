using MediatR;
using StudentManagement.API.Data;
using StudentManagement.API.Library.Queries;
using StudentManagement.API.Model;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.API.Library.Handlers
{
    public class GetStudentByIDHandler : IRequestHandler<GetStudentByIdQuery, StudentModel>
    {
        private readonly IMediator _mediator;
        public GetStudentByIDHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<StudentModel> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var listStudent = await _mediator.Send(new GetStudentListQuery());
            var findStudent = listStudent.Where(x => x.Id == request.id).FirstOrDefault(); // check id thông qua request 
            return findStudent; 
        }
    }
}
