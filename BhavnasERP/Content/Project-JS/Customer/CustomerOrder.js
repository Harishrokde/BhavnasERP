var CostomerOrder = function () {
    $("#costomerOrder").modal('show');
}
$(document).ready(function () { getMainCategoryList(); });
var saveCustomerOrder = function () {
    var Id = $("#hdnID").val();
    var OrderDate = $("#txtOrderDate").val();
    var DeliveryDate = $("#txtDeliveryDate").val();
    var TransactionMode = $("#txtTransactionMode").val();
    var Amount = $("#txtAmount").val();
    var Discount = $("#txtDiscount").val();
    var TotalAmount = $("#txtTotalAmount").val();
    var model = {
        Id: Id, OrderDate: OrderDate, DeliveryDate: DeliveryDate, TransactionMode: TransactionMode, Amount: Amount, Discount: Discount, TotalAmount: TotalAmount
    };

    $.ajax({
        url: "/CustomerOrder/SaveCustomerOrder",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            alert(response.Message);

        }
    });
}
var getMainCategoryList = function () {
    $.ajax({
        url: "/CustomerOrder/GetCustomerOrderlist",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            debugger
            alert('welcome'); var html = "";
            $("#tblCustomerOrder tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id +
                    "</td> <td>" + elementValue.OrderDate +
                    "</td><td>" + elementValue.DeliveryDate +
                    "</td><td>" + elementValue.TransactionMode +
                    "</td><td>" + elementValue.Amount +
                    "</td><td>" + elementValue.Discount +
                    "</td><td>" + elementValue.TotalAmount +
                    "</td><td> <input type = 'submit' value = 'Delete' onClick = 'deleteRegistration(" + elementValue.ID + ")'/></td><td> <input type = 'submit' value = 'Edit' onClick = 'Editdata(" + elementValue.ID + ")'/></td><td> <input type = 'submit' value = 'CategoryDetail' onClick = 'CategoryDetail(" + elementValue.ID + ")'/></td></tr>";

            });
            $("#tblCustomerOrder tbody").append(html);
            deleteRegistration();

        }
    });
}
var deleteRegistration = function (id) {
    debugger
    var model = { ID: id };
    alert("Hello");
    $.ajax({
        url: "/CustomerOrder/deletemvc/",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            alert("Record Deleted Successfully ....");
        }
    });
}
var Editdata = function (id) {
    debugger
    var model = { ID: id };
    alert("Record Edit Successfully ....");
    $.ajax({
        url: "CustomerOrder/GetEditData ",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            $("#txtId").val(response.model.Id);
            $("#txtOrderDate").val(response.model.OrderDate);
            $("#txtDeliveryDate").val(response.model.DeliveryDate);
            $("#txtTransactionMode").val(response.model.TransactionMode);
            $("#txtAmount").val(response.model.Amount);
            $("#txtDiscount").val(response.model.Discount);
            $("#txtTotalAmount").val(response.model.TotalAmount);
        }
    });
}
var CategoryDetail = function (Id) {
    debugger;
    var model = { ID: Id }
    $.ajax({
        url: "/CustomerOrder/GetEditData",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            $("#CategoryModal").modal('show');

            $("#DetailCategory").empty();

            var html = "";
            html += "<div class='row'>";
            html += "<div class='col-sm-6'>";
            html += "<b>Id:</b>&nbsp&nbsp&nbsp<span>" + response.model.Id + "</span>";
            html += "</br>";
            html += "<b>OrderDate:</b>&nbsp&nbsp&nbsp<span>" + response.model.OrderDate + "</span>";
            html += "</br>";
            html += "<b>DeliveryDate:</b>&nbsp&nbsp&nbsp<span>" + response.model.DeliveryDate + "</span>";
            html += "</br>";
            html += "<b>TransactionMode:</b>&nbsp&nbsp&nbsp<span>" + response.model.TransactionMode + "</span>";
            html += "</br>";
            html += "<b>Amount:</b>&nbsp&nbsp&nbsp<span>" + response.model.Amount + "</span>";
            html += "</br>";
            html += "<b>Discount:</b>&nbsp&nbsp&nbsp<span>" + response.model.Discount + "</span>";
            html += "</br>";
            html += "<b>TotalAmount:</b>&nbsp&nbsp&nbsp<span>" + response.model.TotalAmount + "</span>";
            html += "</div>";
            html += "</div>";

            $("#DetailCategory").append(html);
        }
    });
};