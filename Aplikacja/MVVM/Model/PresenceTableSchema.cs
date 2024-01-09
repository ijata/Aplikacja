using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class PresenceTableSchema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PresenceId { get; set; }
        public int ChildId { get; set; }
        public DateTime Date {  get; set; } 
        public int PresenceState { get; set; }
        public string? Description { get; set; }
        public int IsAccepted { get; set; }
    }
}
