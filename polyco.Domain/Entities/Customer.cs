using System.ComponentModel.DataAnnotations;

namespace polyco.Domain.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string BusinessName { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string BusinessType { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Ein { get; set; } = string.Empty;
    }
}