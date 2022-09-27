$(function() {
    let count = 0;

//Takes two arguments, the name of the event, and the event handler.
//Increments count when scrolling.
/*
$(document).on('scroll', function() { 
    count++
    $('h2').text("You scrolled " +  count + " times.")
})
*/

/*
$('input').on('focus', function(){

    $('h2').html("You're are focused on the textbox!")
});

    $('input').on('focusout', function(){

    $('h2').html("You are no longer focused on the textbox.")
});
*/

/*
$('input').on('blur', function() { 

    alert("You have left the textbox.")
});

$('input').on('change', function() {
    count++

    $('h2').text("You have made " +  count + " edit(s).")
});
*/

//$('input').focusin(function() {$('h2').text("In focus")} );
//$('input').focusout(function() {$('h2').text("Out of focus")} );

//$('input').keyup(function() {$('h2').text($('input').val())});
$('input').keydown(function() {$('h2').text($('input').val())});
})