$(function() { 
    console.log('Script Loaded');

    //.css('background-color', 'red');

    $('li').children('span').slideUp(0);

    $('ul').children('li').click(function() { 

        $(this).children().slideToggle();
        $('li').not(this).children('span').slideUp();
    });




} );