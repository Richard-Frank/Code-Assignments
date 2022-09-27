$(function() {

    
    $('#demo').click(function() { 

        $('img').hide();
        //Waits 2 seconds, and then fades in over the course of 3 seconds.
        $('img').delay(2000).fadeIn(3000);

    });
    
    $('img').hover(function() { 

        $(this).animate({top: "125px"}, "fast", function() { $(this).animate({top: "0px"}, "slow")});

    });

    $('#stop').click(function() { 

        $('img').animate().stop(true,true);
    });
    
    
    
    
    
});