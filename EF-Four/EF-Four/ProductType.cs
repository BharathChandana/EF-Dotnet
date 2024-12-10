using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Four
{
    internal class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductTypeId {  get; set; }

        [Required]
        public string ProductTypeName {  get; set; }

        List<Product> products { get; set; }
    }
}
