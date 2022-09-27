$(function () {


   $('#walk').click(function() { 

    Loop();

    });

    $('#stop').click(function() { 

        //Stops the animation where it is.
        $('.walking').stop(true, false);

    });

    $('#reload').click(function() { 

        //Reloads the page. Nothing fancy.
        location.reload();

    });

    function Loop() {
    //Snaps the walker to the next frame of sprite, and moves the div to the right.
    $('.walking').animate({backgroundPositionX: "-180px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "-350px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "-560px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "-755px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "-938px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "-1120px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "-1316px", marginLeft: ["+=10", "linear"]}, 0).delay(100)
                 .animate({backgroundPositionX: "0px", marginLeft: ["+=10", "linear"]}, 0),
                 Loop(); //Call the function again, thus looping the animation. Hoo-ray.
    }
                 
});
