using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mooc.Models
{
    [Table("Answer_Choices")]
    public class AnswerChoice
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsAnswer { get; set; }
    }
}
