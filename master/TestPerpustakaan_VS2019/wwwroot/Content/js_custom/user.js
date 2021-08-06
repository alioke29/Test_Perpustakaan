
function removeElementsFromArray(someArray, filter) {
    var newArray = [];
    for (var index = 0; index < someArray.length; index++) {
        if (filter(someArray[index]) == false) {
            newArray.push(someArray[index]);
        }
    }
    return newArray;
}

function isNullOrUndefined(item) {
    return (item == null || typeof (item) == "undefined");
}

window.onload = function () {

}

function getMessageValidationBorder() {

    var userName = $("#txtUserName").val();
    var password = $("#txtPass").val();
    var confirmPass = $("#txtConfirmPass").val();
    var fullname = $("#txtFullname").val();
    var email = $("#txtEmail").val();
    var locationId = $("#ddlLocation").val();
    var roleId = $("#ddlRole").val();

    if (userName == '') $("#txtUserName").css("border", "1px solid red")
    else $("#txtUserName").css("border", "");

    if (password == '') $("#txtPass").css("border", "1px solid red")
    else $("#txtPass").css("border", "");

    if (confirmPass == '') $("#txtConfirmPass").css("border", "1px solid red")
    else $("#txtConfirmPass").css("border", "");

    if (fullname == '') $("#txtFullname").css("border", "1px solid red")
    else $("#txtFullname").css("border", "");

    if (email == '') $("#txtEmail").css("border", "1px solid red")
    else $("#txtEmail").css("border", "");

    if (locationId == '') $("#ddlLocation").css("border", "1px solid red")
    else $("#ddlLocation").css("border", "");

    if (roleId == '') $("#ddlRole").css("border", "1px solid red")
    else $("#ddlRole").css("border", "");


}

function getSave() {

    var id = $("#hdnId").val();

    var userName = $("#txtUserName").val();
    var password = $("#txtPass").val();
    var confirmPass = $("#txtConfirmPass").val();
    var fullname = $("#txtFullname").val();
    var email = $("#txtEmail").val();
    var locationId = $("#ddlLocation").val();
    var roleId = $("#ddlRole").val();

    var isLogin;
    if ($("#chkIsLogin").prop("checked"))
        isLogin = 'true';
    else
        isLogin = 'false';

    var isActive = $("#ddlIsActive").val();

    var paramAll = userName + '~' + password + '~' + confirmPass + '~' +
                   fullname + "~" + email + "~" + locationId + "~" +
                   roleId + "~" + isLogin + "~" + isActive;


    $("#mask").show();

    var userId = '';
    if (id != null)
        userId = id;

    $.ajax({
        url: getBaseURL() + '/User/AddEditUser/?id=' + userId,
        method: 'POST',
        dataType: "json",
        data: {
                paramAll: paramAll
        },
        cache: false,
        success: function (json) {

            $("#mask").hide();

            if (json.error == '1') {

                getMessageValidationBorder();
                return;
            }
            else if (json.error == '2') {

                swal({
                    title: "Confirmation",
                    text: "User Name has already exist.",
                    type: "warning",
                    timer: 3000
                },
                function () {
                    return;
                });

            }
            else if (json.error == '3') {

                swal({
                    title: "Confirmation",
                    text: "Password must include alpha and numeric.",
                    type: "warning",
                    timer: 3000
                },
                    function () {
                        return;
                    });
            }
            else if (json.error == '4') {

                swal({
                    title: "Confirmation",
                    text: "Password and Confirm Password does not match.",
                    type: "warning",
                    timer: 3000
                },
                    function () {
                        return;
                    });
            }
            else if (json.error == '5') {

                swal({
                    title: "Confirmation",
                    text: "Email has already exist.",
                    type: "warning",
                    timer: 3000
                },
                    function () {
                        return;
                    });
            }
            else if (json.error == '6') {

                swal({
                    title: "Confirmation",
                    text: "Invalid email.",
                    type: "warning",
                    timer: 3000
                },
                    function () {
                        return;
                    });
            }


            if (json.error == 'Edit') {

                swal({
                    title: "Save success!",
                    text: "Edit user has been saved.",
                    type: "success",
                    timer: 3000
                },
                    function () {
                        getReset();
                    });
            }
            else if (json.error == 'Add') {

                swal({
                    title: "Save success!",
                    text: "Add user has been saved.",
                    type: "success",
                    timer: 3000
                },
                function () {
                    getReset();
                });
            }

        },
        error: function (json) {
            alert(json);
        }
    });   
}

function getDelete(id, userName) {

    swal({
        title: "Are you sure want to delete?",
        text: "User Name = '" + userName + "' \n\n You will not be able to recover this selected data!",
        type: "warning",
        showCancelButton: true,
        cancelButtonText: "NO",
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "YES",
        closeOnConfirm: false
    }, function () {

        $("#mask").show();

        $.ajax({
            url: getBaseURL() + '/User/DeleteUser/?id=' + id,
            type: 'GET',
            dataType: 'json',
            cache: false,
            success: function (json) {
                
                $("#mask").hide();

                if (json.error == '0') {

                    swal({
                        title: "Deleted!",
                        text: "Selected user has been deleted.",
                        type: "success",
                        timer: 3000
                    },
                    function () {
                        getReset();
                    });

                }
            },
            error: function (json) {
                alert(json);
            }
        });


    });
}

function getFilter() {

    var fullname = $("#txtFullnameFilter").val();
    var email = $("#txtEmailFilter").val();
    var isActive = $("#ddlStatusFilter").val();
    var roleId = $("#ddlRoleFilter").val();

    $("#mask").show();

    window.location = getBaseURL() + '/Home/UserList/?code=M1_M1A&isFilter=true&fullname=' + fullname + '&email=' + email +
                      '&isActive=' + isActive + '&roleId=' + roleId;

}

function getView(id, userName, password, confirmPass, fullname, email,
                 locationId, roleId, isLogin, isActive, e) {

    //alert(userName);

    $("#txtUserName").css("border", "");
    $("#txtPass").css("border", "");
    $("#txtConfirmPass").css("border", "");
    $("#txtFullname").css("border", "");
    $("#txtEmail").css("border", "");
    $("#ddlLocation").css("border", "");
    $("#ddlRole").css("border", "");
    
    $("#hdnId").val(id);
    $("#txtUserName").val(userName);
    $("#txtPass").val(password);
    $("#txtConfirmPass").val(confirmPass);
    $("#txtFullname").val(fullname);
    $("#txtEmail").val(email);
    $("#ddlLocation").val(locationId);
    $("#ddlRole").val(roleId);

    if (id == '') {
        $("#chkIsLogin").prop("checked", false)
        $("#chkIsLogin").prop("disabled", true)
        $("#ddlIsActive").val('False');
        $("#title").html('Add User');
    }
    else {

        if (isLogin == 'True')
            $("#chkIsLogin").prop("checked", true);
        else
            $("#chkIsLogin").prop("checked", false);

        $("#chkIsLogin").prop("disabled", false)

        $("#ddlIsActive").val(isActive);
        $("#title").html('Edit User');
    }

    $("#modal-form-userdetail").modal('show');

    e.preventDefault();
}

function getReset() {

    window.location = getBaseURL() + '/Home/UserList/M1_M1A';
}

function getClose() {

    $("#modal-form-userdetail").modal('hide');
}


