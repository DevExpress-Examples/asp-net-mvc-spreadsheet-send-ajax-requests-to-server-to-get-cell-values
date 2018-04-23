using DevExpress.Spreadsheet;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace T318446.Controllers
{
    public class HomeController : Controller {

        public ActionResult Index() {
            return View();
        }

        public ActionResult ValidateSpreadsheet(object Spreadsheet) {
            IWorkbook myWorkBook = SpreadsheetExtension.GetCurrentDocument("Spreadsheet");
            int test = Convert.ToInt32(myWorkBook.Worksheets[0].Cells["B3"].Value.NumericValue);
            return Json(test);
        }

        public ActionResult SpreadsheetPartial() {

            return PartialView("_SpreadsheetPartial");
        }
    }
}