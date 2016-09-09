using System;
using System.ComponentModel.DataAnnotations;

namespace ForwardingProject.Domain.Entities
{
    public class Driver : Person
    {
        [Required(ErrorMessage = "Please enter a HiredDate")]
        public DateTime? HiredDate { get; set; }
        [Required(ErrorMessage = "Please enter a DriverLicense")]
        public string DriverLicense { get; set; }
        [Required(ErrorMessage = "Please enter a MedicalCardExpire")]
        public DateTime? MedicalCardExpire { get; set; }

    }
}
