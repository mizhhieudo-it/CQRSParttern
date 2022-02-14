using MediatR;
using StudentManagement.API.Data;
using StudentManagement.API.Library.Queries;
using StudentManagement.API.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.API.Library.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentModel>>
                                                        // nó là kiểu GetStudentListQuery => trả về 1 list StudentModel
    {
        private readonly IDataAccess _dataAccess; 
        GetStudentListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<StudentModel>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetStudents());
        }
    }
}
