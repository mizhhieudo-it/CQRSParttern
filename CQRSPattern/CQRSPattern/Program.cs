using CQRSPattern.Commands;
using CQRSPattern.Models;
using CQRSPattern.Queries;
using CQRSPattern.Repositories;
using System;

namespace CQRSPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Commands 
            var student = new Student
            {
                IdStudent = 101,
                City = "Ha Noi",
                DateOfBirth = new DateTime(2000, 2, 2),
                Street = "Bac Tu Liem" ,
                FirstName = "A",
                LastName = "Nguyen Van", 
                PostalCode = "0123313132"
            };
            IStudentCommandRepository repoStudentCommand = new StudentCommandRepository();
            var command = new StudentCommands(repoStudentCommand);
            command.SaveStudentData(student);
            Console.WriteLine("Added Student !");
            // test query
            IStudentQueriesRepository repoStudentRepository = new StudentQueriesRepository();
            var query = new StudentQueries(repoStudentRepository);
            var getStudent = query.FindByID(100);
            Console.WriteLine($"ID:{getStudent.Id} - Full Name:{getStudent.FullName} - Address:{getStudent.Address} - Age: {getStudent.Age} ");
            Console.ReadKey();
        }
    }
}
