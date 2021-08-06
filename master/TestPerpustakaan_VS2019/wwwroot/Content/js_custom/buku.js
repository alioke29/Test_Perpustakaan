
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

    var judulBuku = $("#txtJudulBuku").val();
    var pengarang = $("#txtPengarang").val();
    var hargaSewa = $("#txtHargaSewa").val();

    if (judulBuku == '') $("#txtJudulBuku").css("border", "1px solid red")
    else $("#txtJudulBuku").css("border", "");

    if (pengarang == '') $("#txtPengarang").css("border", "1px solid red")
    else $("#txtPengarang").css("border", "");

    if (hargaSewa == '') $("#txtHargaSewa").css("border", "1px solid red")
    else $("#txtHargaSewa").css("border", "");

}

function getSave() {

    var id = $("#hdnId").val();

    var judulBuku = $("#txtJudulBuku").val();
    var pengarang = $("#txtPengarang").val();
    var jenisBuku = $("#ddlJenisBuku").val();
    var hargaSewa = $("#txtHargaSewa").val();

    var paramAll = judulBuku + '~' + pengarang + '~' + 
                   jenisBuku + "~" + hargaSewa;


    $("#mask").show();

    var userId = '';
    if (id != null)
        userId = id;

    $.ajax({
        url: getBaseURL() + '/Buku/AddEditBuku/?id=' + userId,
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
                    text: "Judul Buku has already exist.",
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
                    text: "Edit buku has been saved.",
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
                    text: "Add buku has been saved.",
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

function getDelete(id, judulBuku) {

    swal({
        title: "Are you sure want to delete?",
        text: "Judul Buku = '" + judulBuku + "' \n\n You will not be able to recover this selected data!",
        type: "warning",
        showCancelButton: true,
        cancelButtonText: "NO",
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "YES",
        closeOnConfirm: false
    }, function () {

        $("#mask").show();

        $.ajax({
            url: getBaseURL() + '/Buku/DeleteBuku/?id=' + id,
            type: 'GET',
            dataType: 'json',
            cache: false,
            success: function (json) {
                
                $("#mask").hide();

                if (json.error == '0') {

                    swal({
                        title: "Deleted!",
                        text: "Selected buku has been deleted.",
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

    var judulBuku = $("#txtJudulBukuFilter").val();

    $("#mask").show();

    window.location = getBaseURL() + '/Home/BukuList/?code=M2_M2A&isFilter=true&judulBuku=' + judulBuku;

}

function getView(id, judulBuku, pengarang, jenisBuku, hargaSewa, e) {

    //alert(userName);

    $("#txtJudulBuku").css("border", "");
    $("#txtPengarang").css("border", "");
    $("#ddlJenisBuku").css("border", "");
    $("#txtHargaSewa").css("border", "");
    
    $("#hdnId").val(id);
    $("#txtJudulBuku").val(judulBuku);
    $("#txtPengarang").val(pengarang);
    $("#ddlJenisBuku").val(jenisBuku);
    $("#txtHargaSewa").val(hargaSewa);

    if (id == '') {
        $("#title").html('Add Buku');
    }
    else {
        $("#title").html('Edit Buku');
    }

    $("#modal-form-bukudetail").modal('show');

    e.preventDefault();
}

function getReset() {

    window.location = getBaseURL() + '/Home/BukuList/M2_M2A';
}

function getClose() {

    $("#modal-form-bukudetail").modal('hide');
}


