function GetUsers() {
    setInterval(function () {
        //$.ajax({
        //    type: 'Get',
        //    url: '/Home/GetUsers',
        //    success: function (data) {
        //        console.log(data);
        //    },
        //    error: function (err) {
        //        console.log(err);
        //    }
        //});

        $.ajax({
            url: "/Home/GetUsers",
            method: "GET",
            success: function (data) {
                console.log(data);
            },
            error: function (err) {
                console.log(err);
            }
        });
    }, 1000);

    //setInterval(function () {
    //    var url = "/Home/GetUsers";
    //    var type = "GET";
    //    $.ajax({
    //        type: type,
    //        url: url,

    //    });
    //}, 1000);
}