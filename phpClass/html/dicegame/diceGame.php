<?php
    session_start();


    //Roll the player's six sided dice.
    $playerDice1 = mt_rand(1, 6);
    $playerDice2 = mt_rand(1, 6);
    $playerTotal = $playerDice1 + $playerDice2;

    //Roll the computers six sided dice.
    $computerDice1 = mt_rand(1, 6);;
    $computerDice2 = mt_rand(1, 6);;
    $computerDice3 = mt_rand(1, 6);;
    $computerTotal = $computerDice1 + $computerDice2 + $computerDice3;

    $winner = '';

    //Determine winner
    if(isset($_SESSION['winstreak']))
    {
        $winstreak = $_SESSION['winstreak'];
    }
    else
    {
        $winstreak = 0;
    }

    if($playerTotal > $computerTotal)
    {
        $winner = "You have won the round!";
        $winstreak = $winstreak + 1;
        $_SESSION['winstreak'] = $winstreak;
    }
    else if($playerTotal == $computerTotal)
    {
        $winner = "This round is a draw!";
    }
    else
    {
        $winner = "The computer has won this round!";
        $winstreak = 0;
        $_SESSION['winstreak'] = 0;
    }

?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Dice Game</title>
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
</head>
<body>
<header>
    <?php include ('../template/header.php'); ?>
</header>
<nav>
    <?php include ('../template/nav.php'); ?>
</nav>
<main class="center">
    <h1>Dice Game!</h1>
    <div class="borderless">
        <!--Player Dice-->
        <img class="left" src=../img/dice_<?= $playerDice1 ?>.png>
        <img class="left" src=../img/dice_<?= $playerDice2 ?>.png>
        <!--Computer Dice-->
        <img class="right" src=../img/dice_<?= $computerDice1 ?>.png>
        <img class="right" src=../img/dice_<?= $computerDice2 ?>.png>
        <img class="right" src=../img/dice_<?= $computerDice3 ?>.png>
    </div>
    <div id="dicetext">
        <p class="left">
            Your total is: <?= $playerTotal ?>
        </p>
        <p class="right">
            The computer's total is: <?= $computerTotal ?>
        </p>
        <p>
            <?= $winner ?>
        </p>
        <form method="POST" action="diceGame.php">
            <label for="btnRoll">Your winstreak is: <?= $winstreak ?></label>
            <br>
            <input type="submit" class="center" value="Roll Again!" id="btnRoll" name="btnRoll" />
        </form>
    </div>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>