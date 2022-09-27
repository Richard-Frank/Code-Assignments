$(function() { 
    //Store the html
    let $future5k = $('#future5k').children('ul').detach();
    let $futurehalf = $('#futurehalf').children('ul').detach();
    let $futurefull = $('#futurefull').children('ul').detach();
    let $5k = $('#5k').children().detach('ul');
    let $half = $('#half').children('ul').detach();
    let $full = $('#full').children('ul').detach();

    //Bool for button.
    let current = true;

    //Set the page.
    $('#5k').append($5k);
    $('#half').append($half);
    $('#full').append($full);

    $('li').children('span').slideUp(0);
    $('#future5k').remove();
    $('#futurehalf').remove();
    $('#futurefull').remove();
    Slide();

    function Slide()
    {
    $('ul').children('li').click(function() { 

        $(this).children().slideToggle();
        $('li').not(this).children('span').slideUp();
    });
    }

    //BUTTON
    $('#btnEvents').click(function() { 

        if(current)
        {
            Future();
        }
        else
        {
            Current();
        }
        //Resets the slide feature for the lists.
        Slide();
    });

    function Current()
    {
        $('#5k').children('ul').replaceWith($5k);
        $('#half').children('ul').replaceWith($half);
        $('#full').children('ul').replaceWith($full);
        //console.log("Current has fired.");

        current = true;
        $('li').children('span').slideUp(0);
        $('#btnEvents').val("Future Events")
    }
    function Future()
    {
        $('#5k').children('ul').replaceWith($future5k);
        $('#half').children('ul').replaceWith($futurehalf);
        $('#full').children('ul').replaceWith($futurefull);
        //console.log("Future has fired.");

        current = false;
        $('li').children('span').slideUp(0);
        $('#btnEvents').val("Current Events")
    }

} );