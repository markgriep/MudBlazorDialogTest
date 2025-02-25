using System;
using System.Collections.Generic;

namespace MudBlazorDialogTest.Models
{


    //public partial class SelectionPool
    public partial class SelectedForTesting
    {
        public int Id { get; set; }

        public int TestNumber { get; set; }

        public string? TestType { get; set; }   // Drug (D) or Alcohol (A)

        public int? EmployeeId { get; set; }

        public DateTime? TestDate { get; set; }

        public string? ExamTimeInString { get; set; }

        public DateTime? ExamTimeIn { get; set; }

        public string? ExamTimeOutString { get; set; }

        public DateTime? ExamTimeOut { get; set; }

        public string? ExamResults { get; set; }

        public string? Comments { get; set; }

        public DateTime? PaymentDate { get; set; }



        public string? EmployeeName { get; set; }

        public string? Department { get; set; }              // TODO: Validate that this should be string or change to int and also the Table

        public string? JobCode { get; set; }

        public string? JobTitle { get; set; }



    }
}