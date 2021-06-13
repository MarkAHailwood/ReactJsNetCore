using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ReactDemo.Models;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> _comments;

        static HomeController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Author 1",
                    Text = "Text 1"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Author 2",
                    Text = "Text 2"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Author 3",
                    Text = "Text 3"
                }
            };
        }

        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Comments()
        {
            return Json(_comments);
        }

        [Route("comments/new")]
        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
        {
            //create fake id
            comment.Id = _comments.Count + 1;
            _comments.Add(comment);
            return Content("success");
        }

        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
