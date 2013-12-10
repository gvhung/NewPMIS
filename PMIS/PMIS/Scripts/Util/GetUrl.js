function GetUrl() {
    return "/";
}

$(document).ready(function() {
    $.ajaxSetup({
        statusCode: {
            499: function(data) {
                document.write(data.responseText);
            }
        }
    });
});