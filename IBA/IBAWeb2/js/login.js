$(document).ready(function () {

    $(document).on("click", "#btnLogin", function () {
        var username = $('#username').val();
        var password = $('#password').val();

        $(ajax)({
            url: 'LoginHandler.ashx',
            dataType: 'text',
            async: true,
            type: 'POST',
            data: 'username=' + username + "&password=" + password,
            success: function (isValid) {
                console.log('success: ' + isValid);
                window.location.href = 'UserMain.aspx';
            },
            error: function (response) {
                console.log('There has been an error:  ');
                console.log(response);
            }

        });


    });

});