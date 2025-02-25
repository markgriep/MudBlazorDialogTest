namespace RandomDrugTest.Core.Models.DtoModels
{
    public class DtoEditTestResultsEmployee
    {

        public int TestNumber { get; set; }
        public string? EmployeeName { get; set; }

        public int? EmployeeId { get; set; }


        public string? Department { get; set; }

        public string? JobCode { get; set; }

        public string? JobTitle { get; set; }

        public string? TestType { get; set; }   // Drug (D) or Alcohol (A)

        // THESE _ABOVE_ HERE... NOT editable.



        // THESE _BELOW_ ARE EDITABLE.

        public DateTime? TestDate { get; set; }

        public string? ExamTimeInString { get; set; }

        public DateTime? ExamTimeIn { get; set; }

        public string? ExamTimeOutString { get; set; }

        public DateTime? ExamTimeOut { get; set; }

        public string? ExamResults { get; set; }

        public string? Comments { get; set; }

        public DateTime? PaymentDate { get; set; }





    }
}
