using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class UserRelationsSchema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RelationId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ChildId { get; set; }
        [Required]
        public int RelationType {  get; set; }
    }
}
