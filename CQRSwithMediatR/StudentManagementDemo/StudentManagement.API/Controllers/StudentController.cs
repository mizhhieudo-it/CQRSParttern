using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.Library.Commands;
using StudentManagement.API.Library.Handlers;
using StudentManagement.API.Library.Queries;
using StudentManagement.API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;
        // using method Send( method implement from Irequest) 

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<StudentModel>> Get()
        {
            return await _mediator.Send(new GetStudentListQuery());
        }
        [HttpGet("{id}")]
        public async Task<StudentModel> GetById(int id)
        {
            return await _mediator.Send(new GetStudentByIdQuery(id));
        }
        [HttpPost]
        public async Task<StudentModel> Post([FromBody] StudentModel student)
        {
           await _mediator.Send(new AddStudentCommand(student.FirstName,student.LastName));
            return student;
        }
    }
}
