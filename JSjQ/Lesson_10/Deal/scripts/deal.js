$(document).ready(function(){

    function card(name,suit,value) {
        this.name = name;
        this.suit = suit;
        this.value = value;
    } 

    var deck = [
        new card('Ace', 'Hearts',11),
        new card('Two', 'Hearts',2),
        new card('Three', 'Hearts',3),
        new card('Four', 'Hearts',4),
        new card('Five', 'Hearts',5),
        new card('Six', 'Hearts',6),
        new card('Seven', 'Hearts',7),
        new card('Eight', 'Hearts',8),
        new card('Nine', 'Hearts',9),
        new card('Ten', 'Hearts',10),
        new card('Jack', 'Hearts',10),
        new card('Queen', 'Hearts',10),
        new card('King', 'Hearts',10),
        new card('Ace', 'Diamonds',11),
        new card('Two', 'Diamonds',2),
        new card('Three', 'Diamonds',3),
        new card('Four', 'Diamonds',4),
        new card('Five', 'Diamonds',5),
        new card('Six', 'Diamonds',6),
        new card('Seven', 'Diamonds',7),
        new card('Eight', 'Diamonds',8),
        new card('Nine', 'Diamonds',9),
        new card('Ten', 'Diamonds',10),
        new card('Jack', 'Diamonds',10),
        new card('Queen', 'Diamonds',10),
        new card('King', 'Diamonds',10),
        new card('Ace', 'Clubs',11),
        new card('Two', 'Clubs',2),
        new card('Three', 'Clubs',3),
        new card('Four', 'Clubs',4),
        new card('Five', 'Clubs',5),
        new card('Six', 'Clubs',6),
        new card('Seven', 'Clubs',7),
        new card('Eight', 'Clubs',8),
        new card('Nine', 'Clubs',9),
        new card('Ten', 'Clubs',10),
        new card('Jack', 'Clubs',10),
        new card('Queen', 'Clubs',10),
        new card('King', 'Clubs',10),
        new card('Ace', 'Spades',11),
        new card('Two', 'Spades',2),
        new card('Three', 'Spades',3),
        new card('Four', 'Spades',4),
        new card('Five', 'Spades',5),
        new card('Six', 'Spades',6),
        new card('Seven', 'Spades',7),
        new card('Eight', 'Spades',8),
        new card('Nine', 'Spades',9),
        new card('Ten', 'Spades',10),
        new card('Jack', 'Spades',10),
        new card('Queen', 'Spades',10),
        new card('King', 'Spades',10)
    ];

 
    
    function DealCards(index = 0)
    {
        let card = deck[index];
    
            if(card.suit === "Hearts")
            {
                $('#btnHeart').css("pointer-events", "none");
                console.log("Heart loop: " + card.name);

                $("<img>").attr('src',`images/cards/${card.suit}/${card.name}.jpg`).appendTo('#heart').hide().fadeIn("slow").delay("1000").
                fadeOut("Slow", function(){
                    index++;
                    if(index < 13)
                    {
                        $('#heart').empty(); DealCards(index)
                    }
                    else
                    {
                        $("<img>").attr('src','images/check_sm.png').appendTo('#heart').hide().fadeIn("Slow")
                        .delay("1000").fadeOut("Slow", function(){ $('#heart').empty(); $('#btnHeart').css("pointer-events", "auto"); });;
                    }
                });         
            }
            else if(card.suit === "Diamonds")
            {
                $('#btnDiamond').css("pointer-events", "none");
                console.log("Diamond loop: " + card.name);

                $("<img>").attr('src',`images/cards/${card.suit}/${card.name}.jpg`).appendTo('#diamond').hide().fadeIn("slow").delay("1000").
                fadeOut("Slow", function(){
                    index++;
                    if(index < 26)
                    {
                        $('#diamond').empty(); DealCards(index)
                    }
                    else
                    {
                        $("<img>").attr('src','images/check_sm.png').appendTo('#diamond').hide().fadeIn("Slow")
                        .delay("1000").fadeOut("Slow", function(){ $('#diamond').empty(); $('#btnDiamond').css("pointer-events", "auto"); });;
                    }
                });
                        
            }
            else if(card.suit === "Clubs")
            {
                $('#btnClub').css("pointer-events", "none");
                console.log("Club loop: " + card.name);

                $("<img>").attr('src',`images/cards/${card.suit}/${card.name}.jpg`).appendTo('#club').hide().fadeIn("slow").delay("1000").
                fadeOut("Slow", function(){
                    index++;
                    if(index < 39)
                    {
                        $('#club').empty(); DealCards(index)
                    }
                    else
                    {
                        $("<img>").attr('src','images/check_sm.png').appendTo('#club').hide().fadeIn("Slow")
                        .delay("1000").fadeOut("Slow", function(){ $('#club').empty(); $('#btnClub').css("pointer-events", "auto"); });;
                    }
                });
                        
            }
            else if(card.suit === "Spades")
            {
                $('#btnSpade').css("pointer-events", "none");
                console.log("Spade loop: " + card.name);

                $("<img>").attr('src',`images/cards/${card.suit}/${card.name}.jpg`).appendTo('#spade').hide().fadeIn("slow").delay("1000").
                fadeOut("Slow", function(){
                    index++;
                    if(index < 52)
                    {
                        $('#spade').empty(); DealCards(index)
                    }
                    else
                    {
                        $("<img>").attr('src','images/check_sm.png').appendTo('#spade').hide().fadeIn("Slow")
                        .delay("1000").fadeOut("Slow", function(){ $('#spade').empty(); $('#btnSpade').css("pointer-events", "auto"); });;
                        
                    }
                });
                        
            }
            else
            {
                index++; DealCards(index);
            }          
    }

    $('#btnHeart').click(function() { DealCards(0); });
    $('#btnDiamond').click(function() {DealCards(13); })
    $('#btnClub').click(function() {DealCards(26); })
    $('#btnSpade').click(function() {DealCards(39); })
    
    
});  // end of ready