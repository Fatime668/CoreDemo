using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.GetComments(2);
            return View(values);
        }
    }
}
