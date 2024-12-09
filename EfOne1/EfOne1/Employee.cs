using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfOne1
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId {  get; set; }

        [Required]
        [MaxLength (50)]
        public string EmployeeName {  get; set; }

        [Required]
        [MaxLength (50)]
        public string EmployeeRole {  get; set; }

       
        public double EmployeeSalary { get; set; }

        [Required]
        [MaxLength (20)]
        public string EmployeeGender {  get; set; }
    }
}
