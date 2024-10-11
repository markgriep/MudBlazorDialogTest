using System;
using System.Collections.Generic;

namespace MudBlazorDialogTest.Models
{

    public partial class SpecialAssignment
    {
        public int Id { get; set; }

        public int? EmployeeId { get; set; }

        public string? SpecialAssignmentGroup { get; set; }
    }
}