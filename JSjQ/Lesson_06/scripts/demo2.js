$(function() { 


    //Box 1 code.
    $('#slideUp').click(function() { 

        $('#box1').slideUp('slow');
    });

    $('#slideDown').click(function() { 

        $('#box1').slideDown('fast');
    });

    $('#slideUpDown').click(function() { 
        //500 ms
        $('#box1').slideToggle(500);
    });


    //Box 2 code.
    $('#fadeOut').click(function() {

        $('#box2').fadeOut('slow');
    });

    $('#fadeIn').click(function() {

        $('#box2').fadeIn('fast');
    });

    $('#fadeInOut').click(function() {

        $('#box2').fadeToggle(2000);
    });

    $('#fadeTo50').click(function() {

        //Sets opacity to 50% in 1000ms
        $('#box2').fadeTo(1000, 0.5);
    });

    $('#fadeTo100').click(function() {

        //Sets opacity to 100% over 1000ms
        $('#box2').fadeTo(1000, 1.0);
    });

    //Box 3 Code
    $('#hide').click(function() {

        $('#box3').hide();
    });

    $('#show').click(function() {

        $('#box3').show();
    });

    $('#hideShow').click(function() {

        $('#box3').toggle();
    });







} );