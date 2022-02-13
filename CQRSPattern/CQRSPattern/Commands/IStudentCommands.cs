using CQRSPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Commands
{
    public interface IStudentCommands
    {
        void SaveStudentData(Student student);


    }
}
