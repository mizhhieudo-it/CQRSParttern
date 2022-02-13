using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Street { get; set; }
        public string  City { get; set; }
        public string PostalCode { get; set; }
    }
}
