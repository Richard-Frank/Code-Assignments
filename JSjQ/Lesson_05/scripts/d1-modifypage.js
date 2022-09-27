/*
|---Legacy Code---|
All jQuery code goes inside the curly brackets. $declares jQuery.
$(document).ready(function() { };)
*/

//New/current ready statement.
$(function() { 
    //Item 1 = Red, Item 2 = Blue, Item 3 = Green

    //Hold Alt and click the lines for writing on multiple lines.
    $("div").css("background-color", "yellow");
    $("#item1").css("background-color", "red");
    $("#item2").css("background-color", "blue");
    $("#item3").css("background-color", "green");

    $("a").css("background-color", "white");
    //Change the links to block display so they take up the whole line instead of only the text space.
    $("a").css("display", "block");

    $("h3").text("Do Something Awesome")
    //Multiple in one line, uses : and ,
    $("h3").css( {"font-size": "2em",
                    "padding-left": "40%"});

    //Takes two arguments, the source and the value.
    //$("a").attr("href", "http://www.fvtc.edu");

    //Uses the children of the items.
    $("#item1 a").attr("href", "http://www.redbox.com");
    $("#item2 a").attr("href", "http://www.bluebox.com");
    $("#item3 a").attr("href", "http://www.greenbox.com");

    //Dynamically adds a class to the p tags using jQuery
    $("p").addClass("myfont");

    //Add a click event to the h3 tag.
    $("h3").click(function() { 
        
        $("p").removeClass("myfont");
        //Toggle is a shortcut for show and hide. Time is in ms | Keywords "fast" and "slow"
        $("#item1 img").toggle(1000);


        if($("#item2 img").is(":visible"))
        {
            $("#item2 img").fadeOut("slow");
        }
        else
        {
            $("#item2 img").fadeIn("fast");
        }

        //fadeToggle is similar to what is happening in the if/else for item2
        $("#item3 img").fadeToggle(2000);

    });


} );