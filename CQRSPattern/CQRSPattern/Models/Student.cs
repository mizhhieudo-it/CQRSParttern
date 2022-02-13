using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Models
{
    internal class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Street { get; set; }
        public string  City { get; set; }
        public string PostalCode { get; set; }
    }
}
