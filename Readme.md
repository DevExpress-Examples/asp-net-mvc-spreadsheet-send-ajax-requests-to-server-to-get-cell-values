<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553923/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T318446)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T318446/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T318446/Controllers/HomeController.vb))
* [_SpreadsheetPartial.cshtml](./CS/T318446/Views/Home/_SpreadsheetPartial.cshtml)
* **[Index.cshtml](./CS/T318446/Views/Home/Index.cshtml)**
<!-- default file list end -->
# Spreadsheet - How to perform a request to the server using jQuery.ajax to get cell values  


<p>It is necessary to update the Spreadsheet state before sending a request to the server. Data for jQuery.ajax is prepared manually, so we cannot automatically trigger editor updates.</p>
<p>There are two possible solutions:<br><br>1) Use <strong>Ajax.BeginForm</strong> instead of a custom $.ajax request. So, the required information will be prepared automatically before the form is posted.<br><br>2) Call our non-documented <strong>OnPost</strong> method that collects all required information for the Spreadsheet. Please note that the name or implementation of this method may be changed in the future without any notification.</p>
<p> </p>


```js
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
```


<p> </p>

<br/>


