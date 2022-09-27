$(function() {

    
    $('#demo').click(function() { 

        //$('h1').animate({fontSize: "275%", opacity: 0.5, left: +500}, 2000);

        //Contains callback function. Function is called when the animate has finished.
        
        $('h1').animate({fontSize: "50%", opacity: 0.7},2000,
        function() {
            $('h2').next().fadeOut(1000).fadeIn(1000); //Text above button will fade in and out after animation for h1 completes.
        });
        
       
        //Slides to the right, and increases font size.
        $('h1').animate({fontSize: "350%", left: "+=2500"}, 3000);
        
    });
    


    
    
});