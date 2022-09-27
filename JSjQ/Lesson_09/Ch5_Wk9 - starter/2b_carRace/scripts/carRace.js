$(function () {

    $('#start').click(function() { 
        //Math.random() * 5; //Math gives any number from 0 to 1. This gives any number less than 5.
        //Math.random() * 5 + 3; //Three is the minimum number, and this will give any number less than 8.

        let speedRed = Math.floor(((Math.random() * 5) +3 ) * 1000 );
        let speedGreen = Math.floor(((Math.random() * 5) +3 ) * 1000 );

        //Move 1350px to the right at a random speed.
        $('#car1').animate({left: "1350px"}, speedRed);

        //Move 1350 to the right at a random speed.
        $('#car2').animate({left: "1350px"}, speedGreen);


    });

    $('#reload').click(function() { 

        //Refreshes screen, similar to f5
        //location.window.reload();
        location.reload();

    });

});
