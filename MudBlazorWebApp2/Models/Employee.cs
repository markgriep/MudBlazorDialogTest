using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;



namespace MudBlazorWebApp2.Models
{
    public  class Employee
    {
        public int Id { get; set; }

        public int? EmployeeId { get; set; }

        public string? FullName { get; set; }

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? JobTitle { get; set; }

        public string? Department { get; set; }
    }
}
