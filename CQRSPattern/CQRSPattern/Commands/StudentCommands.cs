using CQRSPattern.Models;
using CQRSPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Commands
{
    public class StudentCommands : IStudentCommands
    {
        private readonly IStudentCommandRepository _repoStudent;
        public StudentCommands(IStudentCommandRepository repoStudent)
        {
            _repoStudent = repoStudent;
        }
        public void SaveStudentData(Student student)
        {
            _repoStudent.SaveStudent(student);
        }
    }
}
