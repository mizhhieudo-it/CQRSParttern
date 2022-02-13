using CQRSPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Repositories
{
    internal class StudentQueriesRepository : IStudentQueriesRepository
    {
        public Student GetById(int IdStudent)
        {
            // lấy bản ghi sv từ DB

            return new Student()
            {
                IdStudent = 100,
                FirstName = "Nguyen Van",
                LastName = "X",
                DateOfBirth = new DateTime(2000, 1, 1),
                Street = "101 PHO HUE",
                City = "HA NOI",
                PostalCode = "3123123123"
            };
        }
    }
}
