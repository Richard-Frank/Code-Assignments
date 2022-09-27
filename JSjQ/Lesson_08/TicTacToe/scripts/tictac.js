$(function(){
    //alert("Working");

    let x = "<img src='img/x.png' />";
    let o = "<img src='img/o.png' />";

    let p1victory = 0;
    let p2victory = 0;
    let victory = false;

    let player = 1; //Starts as player 1

    let p1Arr = new Array();
    let p2Arr = new Array();

    $('td').click(function() { 
        //alert(this.id);

        if(player === 1)
        {
            $(this).html(x);
            //Prevents players overriding each other's inputs.
            $(this).css("pointer-events", "none");

            //Add their move to Player 1's array.
            p1Arr.push(this.id);
            //alert(p1Arr);
            win(p1Arr);

            player = 2;
        }
        else
        {
            $(this).html(o);
            $(this).css("pointer-events", "none");

            p2Arr.push(this.id);
            //alert(p2Arr);
            win(p2Arr);

            player = 1;
        }

    });

    $('#btnReset').click(function() { 
        //Clear the board and set up for a new game.

        $('td').css("pointer-events", "auto")
        $('td').html("");
        $('#winner').text("");

        player = 1;
        victory = false;
        p1Arr = [];
        p2Arr = [];


    });

    function win (currentPlayer)
    {
        //alert(currentPlayer);

        currentPlayer = currentPlayer.sort(); //Sort the ids

        ///
        //Horizontal Wins
        ///
        if(currentPlayer.includes("td0") && currentPlayer.includes("td1") && currentPlayer.includes("td2"))
        {
            //Remove all non-winning squares.
            $('td').not('#td0, #td1, #td2').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }
        else if(currentPlayer.includes("td3") && currentPlayer.includes("td4") && currentPlayer.includes("td5"))
        {
            //Remove all non-winning squares.
            $('td').not('#td3, #td4, #td5').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }
        else if(currentPlayer.includes("td6") && currentPlayer.includes("td7") && currentPlayer.includes("td8"))
        {
            //Remove all non-winning squares.
            $('td').not('#td6, #td7, #td8').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }
        ///
        //VERTICAL WINS
        ///
        else if(currentPlayer.includes("td0") && currentPlayer.includes("td3") && currentPlayer.includes("td6"))
        {
            //Remove all non-winning squares.
            $('td').not('#td0, #td3, #td6').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }
        else if(currentPlayer.includes("td1") && currentPlayer.includes("td4") && currentPlayer.includes("td7"))
        {
            //Remove all non-winning squares.
            $('td').not('#td1, #td4, #td7').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }
        else if(currentPlayer.includes("td2") && currentPlayer.includes("td5") && currentPlayer.includes("td8"))
        {
            //Remove all non-winning squares.
            $('td').not('#td2, #td5, #td8').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }

        ///
        //DIAGONAL WINS
        ///
        else if(currentPlayer.includes("td0") && currentPlayer.includes("td4") && currentPlayer.includes("td8"))
        {
            //Remove all non-winning squares.
            $('td').not('#td0, #td4, #td8').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }
        else if(currentPlayer.includes("td6") && currentPlayer.includes("td4") && currentPlayer.includes("td2"))
        {
            //Remove all non-winning squares.
            $('td').not('#td6, #td4, #td2').html("");

            //Increment player wins.
            if(player === 1)
            {
                p1victory++;
                $('#player1').html(`Player 1 Victories: ${p1victory}`);
            }
            else
            {
                p2victory++;
                $('#player2').html(`Player 2 Victories: ${p2victory}`);
            }

            victory = true;

            //Declare winner.
            $('#winner').html(`<b>Player ${player} has won the game!</b>`);
            //Lock out game inputs after a win.
            $('td').css("pointer-events", "none");
        }


        ///
        //Draw
        //
        if(p1Arr.length === 5 && p2Arr.length === 4 && victory == false)
        {
            //Declare draw.
            $('#winner').html(`<b>This game is a draw!</b>`);
            //Lock out game inputs after a draw.
            $('td').css("pointer-events", "none");
        }

    }
});