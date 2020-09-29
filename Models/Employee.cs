using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorADS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Informe o nome")]
        [DisplayName("Nome completo")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Informe o código")]
        [DisplayName("Código")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe o cargo")]
        [DisplayName("Cargo")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe a localização")]
        [DisplayName("Localização")]
        public string OfficeLocation { get; set; }
    }
}
