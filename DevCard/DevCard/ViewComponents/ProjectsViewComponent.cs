using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var projects = new List<Project>()
            {
                new Project(1, "dsjajf", "asdffffffffgbiufoadshgfuihaiuogewofdsa", "adsfads", "project-1.jpg"),
                new Project(2, "sadfds", "dsaojfipoasdjfoias[fs", "dsafads", "project-2.jpg"),
                new Project(3, "sadfas", "dsafdsaflsdhfnuioahfuiwehfopiuad", "adsfa", "project-3.jpg"),
                new Project(4, "asdfas", "asdfasdfasdfasdfasdf", "dsafa", "project-4.jpg")
            };
            return View("_Projects", projects);
        }
    }
}
