using System.ComponentModel.DataAnnotations;

namespace TestCoreWebAppMVC.Models
{
    public class Items
    {
        

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get ; set; }
        public string Description { get; set; } 
        public string Title { get; set; }
        [Required]
        public decimal Price  { get; set; }
        [Required]
        public decimal Qty { get; set; }
        public decimal Total { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now; 
        

    }
}
