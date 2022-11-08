using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    Username = "Fatima"
                },
                new UserComment
                {
                    Id=2,
                    Username = "Aynura"
                },
                 new UserComment
                {
                    Id=3,
                    Username = "Gunel"
                }
            };
            return View(commentValues);
        }
    }
}
