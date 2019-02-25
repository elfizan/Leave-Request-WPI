$(document).ready(function () {
    HideAlert();

    //ClearScreen();
})
function GetLogin() {
    //debugger;
    var admin = new Object();
    admin.username = $('#Username').val();
    admin.password = $('#Password').val();
    //if (admin.username == "a" && admin.password == "1") {
    //    alert("Success")
    //    window.location.href = 'http://localhost:18565/api/Divisions/';
    //}
    $.ajax({
        //url: "http://localhost:18565/api/Employees/Login/",
        url: "http://localhost:18565/api/Login/Login/",
        //url: "http://localhost:18565/api/Employees/AutehticatedLogin/",
        type: "GET",
        //data: $('#loginField').serialize(),
        //data: "Username=" + Username + "&Password=" + Password,
        data: admin,
        datatype: "json",
        success: function (request, response) {
            if (request == null) {
                    swal("Oops", "Username or Password Wrong!", "error");
            } else {
                swal({
                    title: "Login!",
                    text: "Horee SUccess Login!",
                    type: "success"
                }, function () {
                    window.location.href = "http://localhost:21501/Provinces/Index/";
                    //window.location.href = '/Supplier/Index/';
                });
            }      
        }
    });
};

function ValidateLogin() {
    var isAllvalid = true;
    if ($('#Username').val() == "" || $('#Name').val() == " ") {
        isAllvalid = false;
        $('#Username').siblings('span.error').css('visibility', 'visible');
    } else {
        $('#Username').siblings('span.error').css('visibility', 'hidden');
    }

    if ($('#Password').val() == "" || $('#Password').val() == " ") {
        isAllvalid = false;
        $('#Password').siblings('span.error').css('visibility', 'visible');
    } else {
        $('#Password').siblings('span.error').css('visibility', 'hidden');
    }

    if (isAllvalid) {
        GetLogin();
    }
}

function HideAlert() {
    $('#Username').siblings('span.error').css('visibility', 'hidden');
    $('#Password').siblings('span.error').css('visibility', 'hidden');
}
