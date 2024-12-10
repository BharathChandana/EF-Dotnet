using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Six.ModelClasses
{
    [Table("ProductType")]
    internal class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PTId {  get; set; }

        [Required]
        [StringLength(50)]
        public string PTName { get; set; }
        public List<Product> products { get; set; }
    }
}
