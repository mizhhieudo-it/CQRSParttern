using CQRSPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Repositories
{
    //write
    public interface IStudentCommandRepository
    {
         void SaveStudent(Student student);

    }
}
