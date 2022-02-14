using MediatR;
using StudentManagement.API.Data;
using StudentManagement.API.Library.Queries;
using StudentManagement.API.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.API.Library.Handlers
{
    // triển khai interface IRequestHandler<tham số truyền vào x ,kiểu trả về y  > => triển khai fun Handle => với hanlder sẽ có kiểu trả về x , y  
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentModel>>
                                                        // tham số truyền vào / Kiểu trả về  
    {
        private readonly IDataAccess _dataAccess; 
        public GetStudentListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<StudentModel>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetStudents());
        }
    }
}
