using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.DTOs
{
    internal class StudentDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int  Age { get; set; }
        public string Address { get; set; }
    }
}
