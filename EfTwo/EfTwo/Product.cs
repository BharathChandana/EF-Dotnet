using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTwo
{
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId {  get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName {  get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductQuantity { get; set; }

        [Required]
        [Range(1,500)]
        public int ProductPrice {  get; set; }

    }
}
