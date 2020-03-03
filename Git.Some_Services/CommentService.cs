using Git.Some_Data;
using Git.Some_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Some_Services
{
    public class CommentService
    {
        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    CommentId = model.CommentId,
                    Content = model.Content,
                    Author = model.Author

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1; 
            }
        }

        public IEnumerable<CommentListItem> GetComments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Comments
                        .Select(
                        e =>
                        new CommentListItem
                        {
                            CommentId = e.CommentId,
                            Author = e.Author

                        });

                return query.ToArray(); 
            }
        }

        public CommentDetail GetCommentbyId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.CommentId == id);
                return
                    new CommentDetail
                    {
                        CommentId = entity.CommentId,
                        Author = entity.Author,

                    };
            }
        }

        public bool UpdateComment(CommentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == model.CommentId);

                entity.CommentId = model.CommentId;
                entity.Author = model.Author;
                entity.Content = model.Content;

                return ctx.SaveChanges() == 1; 
            }
        }

        public bool DeleteComment(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == commentId);

                ctx.Comments.Remove(entity);

                return ctx.SaveChanges() == 1; 
            }
        }
    }
}
