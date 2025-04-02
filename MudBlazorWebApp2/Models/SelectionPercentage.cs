using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

//namespace RandomDrugTest.Core.Models
namespace MudBlazorDialogTest.Models
{

    [Table("SelectionPercentages")]
    public partial class SelectionPercentage
    {
        public int Id { get; set; }

        public string? TestGroup { get; set; }

        public string? TestType { get; set; }

        //public string? UpdateDateString { get; set; }

        public DateTime UpdateDate { get; set; }

        public string? EffectiveStatus { get; set; }

        public int PercentageRequired { get; set; }
    }
}