using MediatR;
using StudentManagement.API.Model;
using System.Collections.Generic;

namespace StudentManagement.API.Library.Queries
{
    public record GetStudentListQuery():IRequest<List<StudentModel>>;
}
