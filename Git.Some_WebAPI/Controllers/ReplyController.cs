using Git.Some_Models;
using Git.Some_Models.ReplyModels;
using Git.Some_Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Git.Some_WebAPI.Controllers
{
    [Authorize]
    public class ReplyController : ApiController
    {
        public IHttpActionResult Get()
        {
            ReplyService replyService = CreateReplyService();
            var reply = replyService.GetReply();
            return Ok(reply);
        }

        public IHttpActionResult Post(ReplyCreate reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();

            return Ok(reply);
        }

        public IHttpActionResult Get(int id)
        {
            ReplyService replyService = CreateReplyService();
            var reply = replyService.GetReplyById(id);
            return Ok(reply);
        }
        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteSerivce = new ReplyService(userId);
            return noteSerivce;
        }
        public IHttpActionResult Put(ReplyEdit reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.UpdateReply(reply))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateReplyService();

            if (!service.DeleteReply(id))
                return InternalServerError();

            return Ok();
        }
    }
}
