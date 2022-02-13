using CQRSPattern.DTOs;
using CQRSPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Queries
{
    public class StudentQueries : IStudentQueries
    {
        private readonly IStudentQueriesRepository _repoStudent;
        public StudentQueries(IStudentQueriesRepository repoStudent)
        {
            _repoStudent = repoStudent;
        }
        public StudentDTO FindByID(int StudentID)
        {
            var student = _repoStudent.GetById(StudentID);
            // can use automapper 
            return new StudentDTO
            {
                Id = student.IdStudent,
                FullName = student.FirstName + "  " + student.LastName,
                Address = student.Street + " " + student.City + " " + student.PostalCode,
                Age = Convert.ToInt32(Math.Abs((DateTime.UtcNow - student.DateOfBirth).TotalDays / 365))
            };
        }

    }
}
