using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    internal class UserRelationsSchema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        internal int RelationId { get; set; }
        [Required]
        internal int UserId { get; set; }
        [Required]
        internal int ChildId { get; set; }
        [Required]
        internal int RelationType {  get; set; }
    }
}
