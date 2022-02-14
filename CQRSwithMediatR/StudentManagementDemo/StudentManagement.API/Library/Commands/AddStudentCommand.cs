using MediatR;
using StudentManagement.API.Model;

namespace StudentManagement.API.Library.Commands
{
     public record AddStudentCommand(string FirstName,string LastName):IRequest<StudentModel>;
    
}
