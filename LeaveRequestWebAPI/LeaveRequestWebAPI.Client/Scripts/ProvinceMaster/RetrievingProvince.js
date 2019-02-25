﻿$(document).ready(function () {
    LoadIndexProvince();
    HideAlert();
    $('#table').DataTable({
        "ajax": LoadIndexProvince()
    })
    ClearScreen();
})

function LoadIndexProvince() {
    $.ajax({
        type: "GET",
        url: "http://localhost:18565/api/Provinces/",
        //solving data table
        async: false,
        datatype: "JSON",
        success: function (data) {
            var html = '';
            var i = 1;
            $.each(data, function (index, val) {
                html += '<tr>';
                // untuk menampilkan no
                html += '<td>' + i + '</td>';
                html += '<td>' + val.Name + '</td>';
                //nampilin foreign key
                //html += '<td>' + val.Regency.Name + '</td>';
                html += '<td> <a href="#" onclick="return GetById(' + val.Id + ')">Edit</a>';
                html += ' | <a href="#" onclick="return Delete(' + val.Id + ')">Delete</a> </td>';
                html += '</tr>';
                i++;
            });
            $('.tbody').html(html);
        }
    });
}


function Save() {
    var province = new Object();
    province.Name = $('#Name').val();
    $.ajax({
        url: "http://localhost:18565/api/Provinces/",
        type: 'POST',
        datatype: 'json',
        data: province,
        //success: function (result) {
        //    LoadIndexProvince();
        //    $('#myModal').modal('hide');
        //}
        success: function (response) {
            swal({
                title: "Saved !!!",
                text: "Your data has been saved",
                type: "success"
            }, function () {
                window.location.href = '/Provinces/Index/';

            });
        },
        error: function (response) {
            swal("Ooops, we could't connect to the server!", "error");
        }
    });
};

function Edit() {
    var province = new Object();
    province.Id = $('#Id').val();
    province.Name = $('#Name').val();
    $.ajax({
        url: "http://localhost:18565/api/Provinces/" + province.Id,
        type: "PUT",
        datatype: "json",
        data: province,
        //success: function (result) {
        //    LoadIndexProvince();
        //    $('#myModal').modal('hide');
        //    $('#Name').val('');
        //}
        success: function (response) {
            swal({
                title: "Updated !!!",
                text: "Your data has been Updated",
                type: "success"
            }, function () {
                window.location.href = '/Procinces/Index/';

            });
        },
        error: function (response) {
            swal("Ooops, we could't connect to the server!", "error");
        }
    });
};

function GetById(Id) {
    $.ajax({
        url: "http://localhost:18565/api/Provinces/" + Id,
        type: "GET",
        datatype: "json",
        success: function (result) {
            $('#Id').val(result.Id);
            $('#Name').val(result.Name);

            $('#myModal').modal('show');
            $('#Update').show();
            $('#Save').hide();
        }
    });
};

function Delete(Id) {
    swal({
        title: "Are You Sure?",
        text: "You will not be able to recover this imaginary file!",
        type: "warning",
        showCancelButton: true,
        showCancelButtonColor: "#AD6B55",
        confirmButtonText: "Yes, delete it!",
        closeOnConfirm: false
    }, function () {
        $.ajax({
            url: "http://localhost:18565/api/Provinces/" + Id,
            type: "DELETE",
            success: function (response) {
                swal({
                    title: "Deleted!",
                    text: "That data has been soft delete!",
                    type: "success"
                }, function () {
                    LoadIndexProvince();
                    //window.location.href = '/Supplier/Index/';

                });
            },
            error: function (response) {
                swal("Oops", "We could't connect to the server", "error");
            }
        });
    });
};

function ValidationInsert() {
    var isAllValid = true;
    if ($('#Name').val() == "" || $('#Name').val() == " ") {
        isAllValid = false;
        $('#Name').siblings('span.error').css('visibility', 'visible');
    } else {
        $('#Name').siblings('span.error').css('visibility', 'hidden');
    }
    if (isAllValid) {
        Save();
    }
}

function ValidationUpdate() {
    var isAllValid = true;
    if ($('#Name').val() == "" || $('#Name').val() == " ") {
        isAllValid = false;
        $('#Name').siblings('span.error').css('visibility', 'visible');
    } else {
        $('#Name').siblings('span.error').css('visibility', 'hidden');
    }
    if (isAllValid) {
        Edit();
    }
}

function HideAlert() {
    $('#Name').siblings('span.error').css('visibility', 'hidden');
}

function ClearScreen() {
    $('#myModal').on('hidden.bs.modal', function () {
        $(this).find("input,textarea,select").val('').end();
        $('#Update').hide();
        $('#Save').show();
    });
};