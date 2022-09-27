$(function() { 

    //Anonymous function
    $('#btnAction').click(function() { 
        
        /*
        myFunction();
        alert('Works');

        //Call example expression function and pass data to its var1
        example('test');

        $("#box1").slideToggle("slow",function(){ alert('Box has been toggled.'); })

        */


        for(let x=1; x<6; x++)
        {//Targeting elements by id
            //$('#id' + x).css('background-color', 'red');
            $(`#id${x}`).css('background-color', 'red');
        }
        //Changes background on mouse hover.
        $("#id1,#id2,#id3,#id4,#id5").mouseenter(function() { 
            $(this).css('background-color', 'green');
        });
        //Changes background when mouse leaves the element
        $("#id1,#id2,#id3,#id4,#id5").mouseleave(function() { 
            $(this).css('background-color', 'red');
        });
    });

    /*
    //Functional expressions

    let example = function(var1)
    {
        alert("Take action on var1 " + var1)
    }
    */
   /*
    //Arrow function
    let example = (var1) =>
    {
        alert("Take action on var1 " + var1)
    }

    //Arrow function | One var only
    let example = var1 =>
    {
        alert("Take action on var1 " + var1)
    }

    //Arrow function | One line only.
    let example = var1 => alert("Take action on var1 " + var1);

    let example = (var1) =>
    {
        //Use the ` instead of " or ' (On the tilde key)
        alert(`Take action on var1  ${var1}`)
    }
    */




});

//Named function
function myFunction()
{
    alert('This is a named function.');
    console.log("Works");
}

