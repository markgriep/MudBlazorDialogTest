using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MudBlazorWebApp2.Models
{
    public class Car
    {
        [DisplayName("THE OWNER")]
        [Required(ErrorMessage = "Owner name is required.")]
        public string? OwnerName { get; set; }

        [AllowedValues(new string[] { "AMC", "CHEV", "DOD", "CAD", "HON", "TOY" })]
        [Required(ErrorMessage = "Make is required and must be certian values...")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Model is required.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1886, 2024, ErrorMessage = "Year must be between 1886 and 2055.")]
        public int Year { get; set; }

        [StringLength(10, ErrorMessage = "Description can't exceed 10 characters.")]
        public string Description { get; set; }

    }
}
