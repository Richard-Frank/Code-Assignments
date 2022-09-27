$(function() { 
    console.log('Script Loaded');


    $('.races').eq(0).hide();
    $('.races').eq(1).slideUp(0);
    $('.races').eq(2).fadeOut(0);

    

    //Toggle Racebox
    $('.race_box').eq(0).click(function(){

        $('.races').eq(0).toggle();
        $('.races').eq(1).slideUp();
        $('.races').eq(2).fadeOut();
    });

    //Slide Racebox
    $('.race_box').eq(1).click(function(){

        $('.races').eq(0).hide();
        $('.races').eq(1).slideToggle();
        $('.races').eq(2).fadeOut();
    });

    //Fadeout Racebox
    $('.race_box').eq(2).click(function(){

        $('.races').eq(0).hide();
        $('.races').eq(1).slideUp();
        $('.races').eq(2).fadeToggle();
    });





} );