using System;
using System.Collections.Generic;

namespace MudBlazorWebApp2.Models
{

    public partial class SpecialAssignment
    {
        public int Id { get; set; }

        public int? EmployeeId { get; set; }

        public string? SpecialAssignmentGroup { get; set; }
    }
}