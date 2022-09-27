$(function() {

    $('dd').hide();

    $('dt').click(function() {

        //Gives the dt the "open" class, then selects the next element and tells it to toggle slide with a speed of 1000ms
        $(this).toggleClass('open').next().slideToggle(1000);
                //                  //      //
    });



});