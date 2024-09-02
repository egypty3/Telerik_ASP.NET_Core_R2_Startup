using System.ComponentModel;

namespace WebApplication3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        [DisplayName("اسم الشركة")]
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string ContactTitle { get; set; }
    }
}
