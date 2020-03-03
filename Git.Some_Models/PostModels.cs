using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Some_Models
{
    public class PostModels
    {
        public class PostCreate
        {
            public string Title { get; set; }
            public string Text { get; set; }
        }
        public class PostEdit
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
        }
        public class PostDetail
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
        }
        public class PostListItem
        {
            public int PostId { get; set; }
            public string Title { get; set; }
        }
    }
}
