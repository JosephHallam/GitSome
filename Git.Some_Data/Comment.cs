using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Some_Data
{
    public class Comment
    {

        [Key]
        public int CommentId { get; set; }

        public string Content { get; set; }

        public string Author { get; set; } //is there a user class I am supposed to be using?


        //Foriegn Key
        //[ForeignKey(nameof(Reply))]
        //public int? ReplyId {get; set;}
        //public virtual Reply Reply {get; set:}


        //Post CommentPost
    }
}
