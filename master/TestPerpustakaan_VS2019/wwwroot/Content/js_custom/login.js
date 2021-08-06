
function getLogin() {

    $("#mask").show();

    var userName = $('#txtUserNameLogin').val();
    var password = $('#txtPasswordLogin').val();

    if (userName == '') {

        swal({
            title: "AD / Email is required!!",
            text: "Please fill ad / email."
        });

        $("#mask").hide();
        return;
    }

    if (password == '') {

        swal({
            title: "Password is required!!",
            text: "Please fill password."
        });
        $("#mask").hide();
        return;
    }


    $.ajax({
        url: getBaseURL() + '/User/GetLogin/',
        method: 'POST',
        dataType: "json",
        data: {
            userName: userName,
            password: password
        },
        success: function (json) {

            $("#mask").hide();

            if (json.error == '1') {

                swal({
                    title: "Login Failed!",
                    text: "AD / email or password incorrect."
                });

                return;
            }
            else if (json.error == '2') {

                swal({
                    title: "User already login!",
                    text: "Please contact call center."
                });

                return;
            }
            else if (json.error == '3') {

                swal({
                    title: "User is inactive!",
                    text: "Please contact call center."
                });

                return;
            }
            else {

                window.location = getBaseURL() + '/Home/Index';
            }


        },
        error: function (json) {
            alert(json.message);
        }
    });

}

function getClearLogin() {

    $('#txtUserNameLogin').val('');
    $('#txtPasswordLogin').val('');
}

function getLogout() {

    $.ajax({
        url: getBaseURL() + '/User/GetLogout',
        type: 'GET',
        dataType: 'json',
        success: function (json) {

            if (json.error == '0') {

                window.location = getBaseURL() + '/Login/Index';
            }

        },
        error: function (json) {
            alert(json.message);
        }
    });

}
