
function getBaseURL() {

    var baseURL;

    if (location.href.indexOf('localhost') > -1) {

        baseURL = location.protocol + "//" + location.hostname + (location.port && ":" + location.port);

    }

    return baseURL;
}

// DYNAMIC BASE URL
//function getBaseURL() {

//    var baseURL;

//    if (location.hostname.indexOf(':') > -1) {

//        baseURL = location.protocol + "//" + location.hostname + (location.port && ":" + location.port);
//    }
//    else {

//        var pathArray = location.pathname.split('/');
//        var appName = "/" + pathArray[1];

//        if (pathArray[1] == '') {

//            if (location.href.indexOf('s://') > -1)
//                baseURL = "https://" + location.hostname;
//            else
//                baseURL = "http://" + location.hostname;
//        }
//        else {

//            if (location.href.indexOf('s://') > -1)
//                baseURL = "https://" + location.hostname + appName;
//            else
//                baseURL = "http://" + location.hostname + appName;
//        }

//    }

//    return baseURL;
//}
