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
        public string? TestGroup { get; set; }


        public string? TestType { get; set; }


        public DateOnly? UpdateDate { get; set; }


        public int? PercentageRequired { get; set; }
    }
}
