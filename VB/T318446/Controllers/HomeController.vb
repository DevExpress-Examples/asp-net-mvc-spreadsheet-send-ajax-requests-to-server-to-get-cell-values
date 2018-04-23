Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc


Namespace T318446.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function ValidateSpreadsheet(ByVal Spreadsheet As Object) As ActionResult
			Dim myWorkBook As IWorkbook = SpreadsheetExtension.GetCurrentDocument("Spreadsheet")
			Dim test As Integer = Convert.ToInt32(myWorkBook.Worksheets(0).Cells("B3").Value.NumericValue)
			Return Json(test)
		End Function

		Public Function SpreadsheetPartial() As ActionResult

			Return PartialView("_SpreadsheetPartial")
		End Function
	End Class
End Namespace