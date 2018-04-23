@Html.DevExpress().Spreadsheet(Sub(settings)
                                   settings.Name = "Spreadsheet"
                                   settings.CallbackRouteValues = New With { _
       Key .Controller = "Home", _
       Key .Action = "SpreadsheetPartial" _
   }
                                   settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                   settings.Height = 500
                                   settings.ReadOnly = False
                                   settings.RibbonMode = SpreadsheetRibbonMode.Ribbon
                               End Sub).Open(Server.MapPath("~/App_Data/MonthlyBudget.xlsx")).GetHtml()