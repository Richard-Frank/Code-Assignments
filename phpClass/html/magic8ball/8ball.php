<?php
    //Session Start should be the FIRST thing called.
    session_start();

    $answer = "Ask me a question.";
    $question = '';

    if (isset ($_POST['txt_Input']))
    {
        $question = $_POST['txt_Input'];
    };

    $previous_question = '';
    //
    if(isset($_SESSION['previous_question']))
    {
        $previous_question = $_SESSION['previous_question'];
    }

    //Create an array
    $responses = [
        'Ask again at a later date.', //0
        'Yes!',
        'No.',
        'It appears to be so...',
        'Reply is hazy, try again later.',
        'Yes, definitely!',
        'What is it you really want to know?',
        'My sources say no.',
        'Outlook is good.',
        'Signs point to yes.',
        'Do not count on it.',
        'Cannot predict this now.',
        'As I see it, yes.',
        'Better not tell you now.',
        'Concentrate when you are asking these questions!',
    ]; //14

    if(empty($question))
    {
        $answer = "Please ask a question.";
    }
    //-1 grabs the length of 1 from the end of a string.
    else if(substr($question, -1) != '?')
    {
        $answer = "Is that a statement or a question? Please use a question mark!";
    }
    else if($previous_question == $question)
    {
        $answer = "You have already asked this question!";
;    }
    else
    {
        //Get random response. //mt_rand needs a lowest range and a highest range. 0-14
        $answer = $responses[mt_rand(0, (count($responses)) -1)];
        //Set session variable previous question.
        $_SESSION['previous_question'] = $question;
    }
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Magic 8 Ball</title>
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
</head>
<body>
<header>
    <?php include ('../template/header.php'); ?>
</header>
<nav>
    <?php include ('../template/nav.php'); ?>
</nav>
<main>
    <div id="center">
        <h1>Magic 8 Ball</h1>

        <p>
            <!--Print out the $answer variable-->
            <marquee scrollamount="14"><?= $answer ?></marquee>
        </p>

        <!--You can see the information in the URL in a GET method. (Useful for debugging if nothing else.)-->
        <form method="POST" action="8ball.php">
            <p>
                <label for="txt_Input">What do you wish to know?</label>
                <br>
                <input type="text" name="txt_Input" id="txt_Input" value="<?= $question ?>" />
            </p>

            <input type="submit" value="Predict the future!" />
        </form>
    </div>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>