$(document).ready(function () { getMainCategoryList(); });
var getMainCategoryList = function () {
    $.ajax({
        url: "/Customer/GetCustomerlist",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            debugger
            alert('welcome'); var html = "";
            $("#tblCustomer tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id +
                    "</td> <td>" + elementValue.Name +
                    "</td><td>" + elementValue.Email +
                    "</td><td>" + elementValue.MobileNo +
                    "</td><td>" + elementValue.State +
                    "</td><td>" + elementValue.City +
                    "</td><td>" + elementValue.PinCode +
                    "</td><td>" + elementValue.Address +
                    "</td><td> <input type = 'submit' value = 'Delete' onClick = 'deleteRegistration(" + elementValue.ID + ")'/></td><td> <input type = 'submit' value = 'Edit' onClick = 'Editdata(" + elementValue.ID + ")'/></td><td> <input type = 'submit' value = 'CategoryDetail' onClick = 'CategoryDetail(" + elementValue.ID + ")'/></td></tr>";

            });
            $("#tblCustomer tbody").append(html);
            deleteRegistration();
        }
    });
}