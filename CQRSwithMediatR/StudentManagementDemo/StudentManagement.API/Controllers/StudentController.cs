using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        public StudentController(IMediator mediator)
        {
            _mediator  = mediator;
        }
        [HttpGet]
        public async Task<List<StudentModel>> get()
        {
            return await _mediator.Send(new GetStudentListQuery());
        }
    }
}
