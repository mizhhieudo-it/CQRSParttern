using StudentManagement.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.API.Data
{
    public class DataAccess : IDataAccess
    {
        private List<StudentModel> _students = new();


        DataAccess()
        {
            _students.Add(new StudentModel {Id = 1 ,FirstName = "A",LastName = "Nguyen Van" });
            _students.Add(new StudentModel {Id = 2 ,FirstName = "B",LastName = "Nguyen Van" });
            _students.Add(new StudentModel {Id = 2 ,FirstName = "C",LastName = "Nguyen Van" });
        }

        public List<StudentModel> GetStudents() { 
             return _students;
        }

        public StudentModel AddStudent(string firstName, string lastName)
        {
            var student = new StudentModel { FirstName = firstName, LastName = lastName };  
            student.Id = _students.Max(x => x.Id)+1;
            _students.Add(student);
            return student;
        }
    }
}
