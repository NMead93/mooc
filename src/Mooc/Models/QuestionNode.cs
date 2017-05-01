using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mooc.Models
{
    [Table("Question_Nodes")]
    public class QuestionNode: Node
    {
        public ICollection<AnswerChoice> AnswerChoices { get; set; }

    }
}
