using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Four
{
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId {  get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Quantity {  get; set; }

        [Required]
        public decimal Price { get; set; }


        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Brand")]
        public int BrandId {  get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId {  get; set; }

        //Navigations
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public ProductType ProductType { get; set; }


    }
}
