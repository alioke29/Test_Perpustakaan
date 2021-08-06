
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

    var idBuku = $("#ddlBuku").val();
    var tanggalMulai = $("#txtTanggalMulai").val();
    var tanggalSelesai = $("#txtTanggalSelesai").val();

    if (idBuku == '') $("#ddlBuku").css("border", "1px solid red")
    else $("#ddlBuku").css("border", "");

    if (tanggalMulai == '') $("#txtTanggalMulai").css("border", "1px solid red")
    else $("#txtTanggalMulai").css("border", "");

    if (tanggalSelesai == '') $("#txtTanggalSelesai").css("border", "1px solid red")
    else $("#txtTanggalSelesai").css("border", "");

}

function getSave() {

    var id = $("#hdnId").val();

    var idBuku = $("#ddlBuku").val();
    var tanggalMulai = $("#txtTanggalMulai").val();
    var tanggalSelesai = $("#txtTanggalSelesai").val();
    var totalSewa = $("#txtTotalSewa").val();

    var paramAll = idBuku + '~' + tanggalMulai + '~' + 
                   tanggalSelesai + "~" + totalSewa;


    $("#mask").show();

    var pinjamId = '';
    if (id != null)
        pinjamId = id;

    $.ajax({
        url: getBaseURL() + '/Pinjam/AddEditPinjam/?id=' + pinjamId,
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
                    text: "Edit peminjaman buku has been saved.",
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
                    text: "Add peminjaman buku has been saved.",
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
            url: getBaseURL() + '/Pinjam/DeletePinjam/?id=' + id,
            type: 'GET',
            dataType: 'json',
            cache: false,
            success: function (json) {
                
                $("#mask").hide();

                if (json.error == '0') {

                    swal({
                        title: "Deleted!",
                        text: "Selected peminjaman buku has been deleted.",
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

    window.location = getBaseURL() + '/Home/PinjamList/?code=M3_M3A&isFilter=true&judulBuku=' + judulBuku;

}

function getView(id, idBuku, pengarang, jenisBuku, hargaSewa, tanggalMulai, tanggalSelesai, totalSewa, e) {

    $("#ddlBuku").css("border", "");
    $("#txtTanggalMulai").css("border", "");
    $("#txtTanggalSelesai").css("border", "");
    
    $("#hdnId").val(id);

    $("#ddlBuku").val(idBuku);
    $("#txtPengarang").val(pengarang);
    $("#txtJenisBuku").val(jenisBuku);
    $("#txtHargaSewa").val(hargaSewa);
    $("#txtTanggalMulai").val(tanggalMulai);
    $("#txtTanggalSelesai").val(tanggalSelesai);
    $("#txtTotalSewa").val(totalSewa);

    if (id == '') {
        $("#title").html('Add Peminjaman Buku');
    }
    else {
        $("#title").html('Edit Peminjaman Buku');
    }

    $("#modal-form-pinjamdetail").modal('show');

    e.preventDefault();
}

function getReset() {

    window.location = getBaseURL() + '/Home/PinjamList/M3_M3A';
}

function getClose() {

    $("#modal-form-pinjamdetail").modal('hide');
}


