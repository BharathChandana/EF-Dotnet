using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Six.ModelClasses
{
    [Table("Product")]
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string Quantity {  get; set; }

        [Required]
        //[StringLength(15)]
        public decimal Price { get; set; }


        //ForeignKey
        [Required]
        public int CategoryId {  get; set; }

        [Required]
        public int BrandId {  get; set; }

        [Required]
        public int PTId { get; set; }

        public Category category { get; set; }
        public Brand brand { get; set; }

        public ProductType productType { get; set; }

    }
}
