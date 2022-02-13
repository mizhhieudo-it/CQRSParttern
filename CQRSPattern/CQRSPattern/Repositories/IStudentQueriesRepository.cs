using System;
using System.Collections.Generic;
using System.Text;
using CQRSPattern.Models; 

namespace CQRSPattern.Repositories
{
    // read 
    public  interface IStudentQueriesRepository
    {
        Student GetById(int IdStudent);
    }
}
