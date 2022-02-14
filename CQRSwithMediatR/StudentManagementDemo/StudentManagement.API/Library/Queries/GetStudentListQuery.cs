using MediatR;
using StudentManagement.API.Model;
using System.Collections.Generic;

namespace StudentManagement.API.Library.Queries
{
    //                                            cho nó kiểu trả về = > get Student list query => trả về 1 list student 
    public record GetStudentListQuery():IRequest<List<StudentModel>>;
    public record GetStudentByIdQuery(int id):IRequest<StudentModel>;
}
