using CQRSPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Repositories
{
    internal class StudentCommandRepository : IStudentCommandRepository
    {
        public void SaveStudent(Student student)
        {
           // Add Student in DB
        }
    }
}
