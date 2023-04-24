<?php

    //Database connection
    include('../template/db_conn.php');

    try
    {
        //Call the database
        $db = new PDO($db_dsn,$db_username,$db_password,$db_options);
        //Select * data from the table.
        $sql = $db->prepare("SELECT * FROM phpclass.movielist;");
        //Database Executes the order.
        $sql->execute();
        //Deliver the data to $rows
        $rows = $sql->fetchAll();

        /*
        echo '<pre>';
        print_r($rows); //Print out the database | Testing
        echo '<pre/>';
        */

    }catch(PDOException $e){ echo $e->getMessage(); exit;}

?>


<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Movie List</title>
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
    <h1 class="center">My Movie List</h1>

    <?php if(isset($_GET['success'])) { ?>
        <p class="success">Movie successfully added/updated.</p>
    <?php } ?>
    <?php if(isset($_GET['delete']) && $_GET['delete'] == '1') { ?>
        <p class="success">Movie was deleted successfully!</p>
    <?php }else if(isset($_GET['delete']) && $_GET['delete'] == '0'){ ?>
        <p class="error">Movie was not deleted properly. Please try again.</p>
    <?php } ?>
    <table border="1" width="65%">

        <tr>
            <th>ID</th>
            <th>Title</th>
            <th>Rating</th>
        </tr>

        <?php foreach($rows as $movie) : ?>
            <tr>
                <td><?= $movie['movie_id'] ?></td>
                <!--Links to the movie update page and passes the movie id to the update page as well.-->
                <td><a href="update.php?id=<?= $movie['movie_id']?>">
                            <?= $movie['movie_title'] ?></a></td>

                <td><?= $movie['movie_rating'] ?></td>
            </tr>
        <?php endforeach; ?>

    </table>

    <p class="center">
        <a href="add.php">Add New Movie</a>
    </p>

</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>