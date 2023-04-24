<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Loops/String</title>
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
    <h1>Loops and String Functions Demo</h1>
    <br>
    <h3>Basic Vars & Stuff</h3>
    <?php
        $number = 100;
        print $number; //Prints out number variable
        echo $number; //Prints out number variable
        echo "<br><strong>".$number."</strong>"; //Prints in bold

        echo "<br><strong>";
        echo $number; //Prints in bold. But using more lines.
        echo "</strong>";

        echo "<br><strong>$number</strong>"; //Prints out number in bold.
        echo '<br><strong>$number</strong>'; //Prints out the string '$number' in bold.
        echo "<br><strong>{$number}</strong>"; //Prints out number in bold. Can use more advanced code inside the brackets.

        $result = "<br><strong>";
        $result .= $number; //Adds number to result.
        $result .= "</strong>"; //Adds closing strong tag to result.
        echo $result; //Prints out number in bold.

    ?>
    <br>
    <hr>
    <h3>Math</h3>
    <hr>
    <?php
    $number_1 = 100;
    $number_2 = "50";
    $number_3 = 50;

    $result_1 = $number_1 + $number_2;
    $result_2 = $number_1 + $number_3;
    echo "<br>".$result_1."<br>".$result_2;


    ?>
    <br>
    <hr>
    <h3>While Loop</h3>
    <hr>
    <?php

    $i = 1;

    While($i < 7)
    {
        echo "<h$i>Greetings World!<h$i><br>";
        $i++; //$i = $i +1; | $i += 1;
    }

    ?>
    <hr>
    <h3>Do While Loop</h3>
    <hr>
    <?php

    $i = 6;

    do //Do while loops always fire once. DO! ...While.
    {
        echo "<h$i>Goodbye World!<h$i><br>";
        $i--; //$i = $i -1; | $i -= 1;
    }While($i > 0);

    ?>
    <hr>
    <h3>For Loop</h3>
    <hr>
    <?php
        for($i = 1; $i <= 6; $i++)
        {
            echo "<h$i>Why am I still here?!<h$i><br>";
        }
    ?>

    <hr>
    <h3>More Fun With Strings</h3>
    <hr>
    <?php
        $full_name = "Bob Smith";
        $full_name = 123;
        $full_name = false;
        $full_name = "Bob Smith";

    //B o b   S m i t h
    //0 1 2 3 4 5 6 7 8
    //      !

    $position = strpos($full_name, " "); //The box it is in, and what you want from it. In this case we want the space.
    echo "<br> the space position is in position $position";

    echo "<br>".$full_name;
    echo "<br>".strtoupper($full_name); //Converts to all uppercase
    echo "<br>".strtolower($full_name); //Converts to all lowercase

    $name_parts = explode(" ", $full_name); //Creates a string array, creating a new item at every space " ";
    echo "<br>First Name: ".$name_parts[0];
    echo "<br>Last Name: ".$name_parts[1];

    ?>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>