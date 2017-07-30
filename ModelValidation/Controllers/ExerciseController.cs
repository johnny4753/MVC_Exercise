using System.Collections.Generic;
using ModelValidation.Models;
using System.IO;
using System.Web.Mvc;
using ModelValidation.Models.ViewModels;

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

        public ActionResult JqueryAjaxGetCustomers()
        {
            return View();
        }

        [HttpPost]
        [ActionName(nameof(JqueryAjaxGetCustomers))]
        public ActionResult JqueryAjaxCustomers()
        {
            var customerViewModels = new List<CustomerViewModel>
            {
                new CustomerViewModel
                {
                    CustomerID = "John",
                    City = "台北",
                    CompanyName = "南京資訊",
                    Phone = "0912345678"
                },
                new CustomerViewModel
                {
                    CustomerID = "Tom",
                    City = "台中",
                    CompanyName = "新人類",
                    Phone = "12345678"
                }
            };
            return Json(customerViewModels);
        }
    }
}