using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirstEFinAsp.netcoreDemo.Models
{
    public class Product
    {
        public int ProductID { set; get; }
        [Required]
        public string ProductName { set; get; }
        [Display(Name ="who buyed")]
        [ForeignKey("CustomerID")]
        public int CustomerID { set; get; }
        
        public Customer Customer { set; get; }
    }
}
