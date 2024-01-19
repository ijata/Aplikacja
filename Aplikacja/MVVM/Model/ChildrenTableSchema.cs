using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class ChildrenTableSchema 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int childernId { get; set; }
        public string? childernFirstName { get; set; }
        public string? childernLastName { get; set; }
        [Required]
        public int isActive { get; set; }
        [Required]
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        //Relacja z tabelą UserRelations
        //public virtual UserRelationsSchema UserRelations { get; set; }

    }
}

