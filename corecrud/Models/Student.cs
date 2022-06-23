using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corecrud.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [Column(TypeName = "varchar(250)")]

        public string Name { get; set; }
        [Required]
        [Display(Name = "Niveau")]
        [Column(TypeName = "varchar(250)")]
        public string Niveau { get; set; }
        [Required]
        [Display(Name = "prenom")]
        [Column(TypeName = "varchar(250)")]
        public string prenom { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
  public DateTime ?BirthDate { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Required]
        [Display(Name = "Email")]
        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "City")]
        [Column(TypeName = "varchar(250)")]
        public string City{ get; set; }

        [Display(Name = "Specialization")]
        [Column(TypeName = "varchar(250)")]
        public string Specialization { get; set; }

        [Required]
        [Display(Name = "numero")]
        [Column(TypeName = "varchar(250)")]
        public string numero { get; set; } = string.Empty;
    }
}
