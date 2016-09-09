using System.ComponentModel.DataAnnotations;
namespace ForwardingProject.Domain.Entities
{
    public abstract class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter a PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter a FaxNumber")]
        public string FaxNumber { get; set; }
    }
}
