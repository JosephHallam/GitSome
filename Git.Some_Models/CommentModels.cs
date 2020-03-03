using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Some_Models
{
    public class CommentCreate
    {
        [Required]
        public int CommentId { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }

        public string Author { get; set; }
    }

    public class CommentDetail
    {
        public int CommentId { get; set; }

        public string Author { get; set; }
    }

    public class CommentEdit
    {
        public int CommentId { get; set; }

        public string Author { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }
    }

    public class CommentListItem
    {
        public int CommentId { get; set; }

        public string Author { get; set; }
    }
}
