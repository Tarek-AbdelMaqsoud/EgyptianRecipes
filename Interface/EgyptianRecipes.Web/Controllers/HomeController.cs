using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgyptianRecipes.Web.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Roles = "Admin")]
        [Authorize]
        public ActionResult Index()
        {
            var egyptianReciepsClient = new EgyptianRecipesService.EgyptianRecipesServiceClient();
            ViewBag.Branches = egyptianReciepsClient.GetAllBranches().ToList();
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("Delete/{id}")]
        public ActionResult Delete(long id)
        {
            var egyptianReciepsClient = new EgyptianRecipesService.EgyptianRecipesServiceClient();
            var isDeleted = egyptianReciepsClient.DeleteBranch(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(long id)
        {
            var egyptianReciepsClient = new EgyptianRecipesService.EgyptianRecipesServiceClient();
            var branch = egyptianReciepsClient.GetBranchesByID(id);
            return View(branch);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(Entities.Branch branch)
        {
            var egyptianReciepsClient = new EgyptianRecipesService.EgyptianRecipesServiceClient();
            String[] errorMessages = null;
            bool hasBeenUpdated = egyptianReciepsClient.UpdateBranch(branch, out errorMessages);

            
            if (!hasBeenUpdated)
            {
                ViewBag.Error = errorMessages;
                return View(branch);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [Authorize]
        public ActionResult About()
        {
           ViewBag.UserPic = UserManager.UserManager.GetThumbnailPhoto(User.Identity.Name);
            return View();
        }
    }
}