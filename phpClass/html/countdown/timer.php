<?php
//Constants
$SEC_PER_MIN = 60;
$SEC_PER_HOUR = 60 * $SEC_PER_MIN;
$SEC_PER_DAY = 24 * $SEC_PER_HOUR;
$SEC_PER_YEAR = 365 * $SEC_PER_DAY;

$NOW = time();
$NEXT_DECADE = mktime(0,0,0,1,1,2030); //The 0th second, at the 0th minute, at the 0th hour on Jan 1st 2030.

//***************************************//
// May 21st 2022 for assignment timer date.
//***************************************//

$seconds = $NEXT_DECADE - $NOW; //The number of seconds between now and 2030.

//How many years?
$years = floor($seconds / $SEC_PER_YEAR);
//Remove years in seconds from the total seconds.
$seconds = $seconds - ($SEC_PER_YEAR * $years);

//How many days?
$days = floor($seconds / $SEC_PER_DAY);
//Remove days in seconds from the total seconds.
$seconds = $seconds - ($SEC_PER_DAY * $days);

//How many hours?
$hours = floor($seconds / $SEC_PER_HOUR);
$seconds = $seconds - ($SEC_PER_HOUR * $hours);

//How many minutes?
$minutes = floor($seconds / $SEC_PER_MIN);
$seconds = $seconds - ($SEC_PER_MIN * $minutes);

//Remaining seconds are stored in $seconds.
?>



<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Countdown Timer</title>
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
    <h1>Countdown Timer</h1>
    <br>
    <p>
        Current Date&Time:
        <?php
        print date("Y-m-d H:i:s")
        ?>
    </p>
    <br>
    <p>Now: <?= $NOW ?></p>
    <p>Next Decade: <?= $NEXT_DECADE ?></p>
    <p>Years: <?= $years ?> | Days: <?= $days ?> | Hours: <?= $hours ?> | Minutes: <?= $minutes ?> | Seconds: <?= $seconds ?></p>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>