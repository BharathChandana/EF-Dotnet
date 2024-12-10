using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Six.ModelClasses
{
    [Table("Brand")]
    internal class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("BName")]
        public string BrandName { get; set; }
        public List<Product> products { get; set; }
    }
}
