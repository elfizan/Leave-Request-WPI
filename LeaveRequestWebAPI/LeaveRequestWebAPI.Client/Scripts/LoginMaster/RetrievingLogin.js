$(document).ready(function () {
    
})

function Authen() {

}

function GetLogin(Username, Password) {
    debugger;
    $.ajax({
        type: 'GET',
        url: "http://localhost:18565/api/Login/",
        data: {
            Username: Username,
            Password: Password
        },
        datatype: 'json',
        success: function (result) {
            $('#Id').val(result.Id);
            $('#Username').val(result.Username);
            $('#Password').val(result.Password);

            $('#myModal').modal('show');
            $('#Update').show();
            $('#Save').hide();
        }
    })
}