//Ready statement
$(function() 
{ 
    //$('#temp').text("<em>This is very cool.</em>"); //Literal, will print everything as text. Including tags.
    $('#temp').html("<em>This is very cool.</em>"); //Parses tags, then prints.

    $('h1').html("<em>This is a very cool page. Yes indeed.</em>");

    //What we want to insert, and what where we want to insert it. In this case insertBefore the #temp id.
    $('<input type="button" value="Hide" id="btnShowHide" />').insertBefore('#temp');

    //Create a click event for the inserted button.
    $('#btnShowHide').click(function() 
    { 
        //toggle between hide() and show()
        $('p').toggle();

        if($('p').is(':visible'))
        {
            $(this).val('Hide');
        }
        else { $(this).val('Show'); }
    } );

    //Adds a <p> tag to the end of the div tag, at the bottom.
    $('div').append("<p>Append me to the list.</p>");

    //Adds a <strong> tag to the start of every <p> tag.
    //$('<strong> Hello </strong>').prependTo('p');

    //Appends the strong tag to the #temp id.
    $('<strong>Hello, </strong>').prependTo('#temp');

    //Appends the <em>Goodbye to every p tag.</em>
    //$('<em>Goodbye</em>').appendTo('p');

    //Appends the <em>Goodbye to the #temp id.</em>
    $('<em> Goodbye!</em>').appendTo('#temp');

    //Removes the #temp id. Removes the whole thing from memory.
    //$('temp').remove()

    //Removes all p tags that contain the word "goods". Case sensitive.
    $('p').remove(':contains("goods")');


});