$(function () {


    $('#start').click(function() { 

        //Chaining animations. animate().animate().animate() etc...
        $('img').animate({top: "100px", right: "150px", width: "11%", height: "11%"}, 3000, "linear")
                        .animate({top: "90px"}, 70, "swing")
                        .animate({top: "100px"}, 100, "swing")
                        //After 1st bump
                        .animate({top: "200px", right: "300px", width: "17%", height: "17%"}, 3000, "linear")
                        .animate({top: "180px"}, 50, "swing")
                        .animate({top: "200px"}, 60, "swing")
                        //After 2nd bump
                        .animate({top: "350px", right: "450px", width: "23%", height: "23%"}, 3000, "linear")
                        .animate({top: "340px"}, 150, "swing")
                        .animate({top: "350px"}, 200, "swing")
                        //After 3rd bump
                        .animate({top: "400px", right: "600px", width: "30%", height: "30%"}, 3000, "linear")
                        .animate({top: "390px"}, 50, "swing")
                        .animate({top: "400px"}, 60, "swing")
                        //After 4th bump
                        .animate({top: "500px", right: "750px", width: "36%", height: "36%"}, 3000, "linear");
                        

    });






});
