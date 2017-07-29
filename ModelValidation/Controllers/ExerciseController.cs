using ModelValidation.Models;
using System.IO;
using System.Web.Mvc;

namespace ModelValidation.Controllers
{
    public class ExerciseController : Controller
    {
        // GET: Exercise
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(ExerciseUploadViewModel exerciseUploadViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var postedFile = exerciseUploadViewModel.HttpPostedFile;
            var fileName = Path.GetFileName(postedFile.FileName);
            var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
            postedFile.SaveAs(path);
            return View();
        }

        public ActionResult AjaxGetMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxGetMessage(string myInput)
        {
            if (myInput != "Hello!")
            {
                TempData["ResponseMessage"] = "請輸入 \"Hello!\"";
            }
            else
            {
                TempData["ResponseMessage"] = "Hello! This is Ajax Call";
            }
            return PartialView("_AjaxGetMessage");
        }
    }
}