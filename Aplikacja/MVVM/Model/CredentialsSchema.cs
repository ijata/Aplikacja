using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class CredentialsSchema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CredentialId { get; set; }
        [Required]
        public string CredentialName { get; set;}
    }
}
