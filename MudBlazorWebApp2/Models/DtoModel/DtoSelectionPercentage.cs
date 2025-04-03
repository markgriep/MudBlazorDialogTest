using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace RandomDrugTest.Core.Models.DtoModels
namespace MudBlazorDialogTest.Models.DtoModels
{
    public class DtoSelectionPercentage
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Testing Group is required.")]
        public string? TestGroup { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Test Type is required.")]
        public string? TestType { get; set; }


        public DateOnly? UpdateDate { get; set; }


        [Required(ErrorMessage = "Some Percentage is required.")]
        public int? PercentageRequired { get; set; }

    }
}
