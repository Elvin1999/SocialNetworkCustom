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
            url: "/Home/GetAllActiveUsers",
            method: "GET",
            success: function (data) {
                let content = "";
                
                for (var i = 0; i < data.length; i++) {
                    let item =`<div class="card">
                             <img class="card-img-top" style="width:50px;height:50px" src="/images/${data[i].imageUrl}" alt="Card image cap">
                            <div class="card-body">
                             <h5 class="card-title">${data[i].userName}</h5>
                        </div>
                    </div>`
                    content += item;
                }
                $("#activeUsers").html(content);
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


GetUsers();