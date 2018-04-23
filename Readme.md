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


