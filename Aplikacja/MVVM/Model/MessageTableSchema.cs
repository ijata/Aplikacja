using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class MessageTableSchema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }
        [Required]
        public int ThreadId {  get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime Date {  get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public int IsView { get; set; }


    }
}
