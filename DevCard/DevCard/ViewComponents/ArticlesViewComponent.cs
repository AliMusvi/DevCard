using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "sadf", "dsaghfusdahuiku ud u sdujdks hui hisda asd ", "blog-post-thumb-card-1.jpg"),
                new Article(2, "sadf", "dsaghfusdahuiku ud u sdujdks hui hisda asd ", "blog-post-thumb-card-2.jpg"),
                new Article(3, "sadf", "dsaghfusdahuiku ud u sdujdks hui hisda asd ", "blog-post-thumb-card-3.jpg"),
                new Article(4, "sadf", "dsaghfusdahuiku ud u sdujdks hui hisda asd ", "blog-post-thumb-card-4.jpg")
            };

            return View("_Articles", articles);
        }
    }
}
