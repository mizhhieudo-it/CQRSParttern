using StudentManagement.API.Model;
using System.Collections.Generic;

namespace StudentManagement.API.Data
{
    public interface IDataAccess
    {
        public List<StudentModel> GetStudents();
        StudentModel AddStudent(string firstName, string lastName);
        //StudentModel GetByID(int id);    
    }
}
