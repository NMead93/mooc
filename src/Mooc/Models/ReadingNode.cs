using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mooc.Models
{
    [Table("Reading_Nodes")]
    public class ReadingNode: Node
    {
        public string Content { get; set; }
    }
}
