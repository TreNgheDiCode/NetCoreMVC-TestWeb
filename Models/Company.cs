using System.ComponentModel.DataAnnotations;

namespace TestWeb.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public ICollection<Mobile> Mobiles { get; set; }
    }
}
