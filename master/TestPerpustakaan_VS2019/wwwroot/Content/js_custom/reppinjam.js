
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

function currencyFormat(num) {
    return 'Rp ' + num.toFixed(2).replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')
}

window.onload = function () {

}

function getFilter() {

    var judulBuku = $("#txtJudulBukuFilter").val();

    $("#mask").show();

    window.location = getBaseURL() + '/Home/RepPinjamList/?code=M4_M4A&isFilter=true&judulBuku=' + judulBuku;

}

function getReset() {

    window.location = getBaseURL() + '/Home/RepPinjamList/M4_M4A';
}



