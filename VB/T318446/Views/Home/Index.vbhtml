<script type="text/javascript">
    function OnClick() {
        var url = "Home/ValidateSpreadsheet/";
        Spreadsheet.OnPost();
        $.ajax({
            type: "POST",
            url: url,
            data: $('form').serialize(),
            success: function (data) {
                myLabel.SetText(data);
            }
        });
    }
</script>


@Using (Ajax.BeginForm("ValidateSpreadsheet", "Home", New AjaxOptions With {.UpdateTargetId = "myLabel", .HttpMethod = "Post", .InsertionMode = InsertionMode.Replace}))



    @Html.DevExpress().Button(Sub(settings)
                                  settings.Name = "Button"
                                  settings.UseSubmitBehavior = False
                                  settings.Text = "Use OnPost"
                                  settings.ClientSideEvents.Click = "OnClick"
                              End Sub).GetHtml()


    @Html.DevExpress().Button(Sub(settings)
                                  settings.Name = "btnSubmit"
                                  settings.Text = "Use Ajax.BeginForm"
                                  settings.UseSubmitBehavior = True
                              End Sub).GetHtml()



    @Html.DevExpress().Label(Sub(settings)
                                 settings.Name = "myLabel"
                                 settings.Text = "Text"
                                 settings.ClientEnabled = True
                                 settings.Properties.EnableClientSideAPI = True
                             End Sub).GetHtml()


    @Html.Action("SpreadsheetPartial")


End Using



