using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mooc.Models
{
    [Table("Video_Nodes")]
    public class VideoNode: Node
    {
        public string VideoFilePath { get; set; }
    }
}
