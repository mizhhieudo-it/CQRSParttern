using CQRSPattern.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Queries
{
    public interface IStudentQueries
    {
        StudentDTO FindByID(int studentID);
    }
}
