using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class MenuTableSchema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string? Posilek1 { get; set; }    
        public string? Posilek2 { get; set; }
        public string? Posilek3 { get; set; }
        public string? Posilek4 { get; set; }    

    }
}
