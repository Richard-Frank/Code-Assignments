$(function(){
    //Chapter 5 of book.
    
   $('#start').click(function() { 

    //Moves 100px to the right.
    //$('#circle').animate({left: "+=100"});

    //Moves 1000px the right, over the span of 3 seconds.
    $('#circle').animate({left: "+=1000"}, 3000);

   });
   
    $('#stop').click(function() { 

        //Snaps to the end of the animation.
        //$('#circle').stop(false, true);

        //Stops the animation in its tracks.
        $('#circle').stop(false, false);

        //Snaps to end of animation.
        //$('#circle').finish();

    });
});