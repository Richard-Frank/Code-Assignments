<?php
//Constants
$SEC_PER_MIN = 60;
$SEC_PER_HOUR = 60 * $SEC_PER_MIN;
$SEC_PER_DAY = 24 * $SEC_PER_HOUR;

$NOW = time();
$SEMESTER_END = mktime(0,0,0,5,22,2022);

$seconds = $SEMESTER_END - $NOW;

//Days
$days = floor($seconds / $SEC_PER_DAY);
$seconds = $seconds - ($SEC_PER_DAY * $days);

//Hours
$hours = floor($seconds / $SEC_PER_HOUR);
$seconds = $seconds - ($SEC_PER_HOUR * $hours);

//Minutes
$minutes = floor($seconds / $SEC_PER_MIN);
$seconds = $seconds - ($SEC_PER_MIN * $minutes);
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
    <style>
        #center {text-align: center}
    </style>
</head>
<body>
<header>
    <?php include ('../template/header.php'); ?>
</header>
<nav>
    <?php include ('../template/nav.php'); ?>
</nav>
<main id="center">
    <h1>The Semester Ends In:</h1>
    <p>Days: <?= $days ?> |
        Hours: <?= $hours ?> |
        Minutes: <?= $minutes ?> |
        Seconds: <?= $seconds ?></p>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>