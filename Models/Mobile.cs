using System.ComponentModel.DataAnnotations.Schema;

namespace TestWeb.Models
{
    public class Mobile
    {
        public int Id { get; set; }
        public string MobileName { get; set; }
        public string MobileImage { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
