using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EkmWebApp.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string fullName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string mobile { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string email { get; set; }
        
        public int age { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public int address { get; set; }


    }
}
