<?php

    //Check to see if the URL has passed an id, and that the id is not empty, and that the id is an int.
    if(isset($_GET['id']) && !empty($_GET['id']) && filter_var($_GET['id'], FILTER_VALIDATE_INT) )
    {
        //Bind the URL id to a local variable.
        $id = $_GET['id'];

        //DATABASE STUFF
        try {
            include ('../template/db_conn.php');
            $db = new PDO ($db_dsn, $db_username, $db_password, $db_options);

            $sql = $db->prepare("SELECT * FROM phpclass.movielist WHERE movie_id = :id");
            //Bind the id passed from the URL.
            $sql->bindValue(":id", $id);
            $sql->execute();
            //Get the data.
            $row = $sql->fetch();

            if(!$row)
            {//If for whatever reason the row returns nothing, it kicks them out to list.
                //$row comes back as false if empty. So this checks for not false.
                header("Location: list.php");
            }

            //Bind the data to local variables.
            $title = $row['movie_title'];
            $rating = $row['movie_rating'];

        } catch(PDOException $e) {$e->getMessage(); exit;}


    }else
    {
        //Returns the user if the id cannot be verified.
        header("Location: list.php");
    }


    //Validate if the input text inputs are filled out and not empty.
    if(isset($_POST['movie_name']) && !empty($_POST['movie_name'])
        && isset($_POST['movie_rating']) && !empty($_POST['movie_rating']) && isset($_POST['movie_id'])
        && !empty($_POST['movie_id']))
    {
        //Prints out the POSTed data for debugging.
        //echo "<pre>"; print_r($_POST); echo "</pre>"; exit;

        //Set the variables with data from the text inputs.
        $movie_title = $_POST['movie_name'];
        $movie_rating = $_POST['movie_rating'];
        $movie_id = $_POST['movie_id'];

        //MORE DATABASE STUFF
        //Get the data from the text inputs, submits to database.
        try
        {
            $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
            $sql = $db->prepare("
                UPDATE phpclass.movielist SET
                movie_title = :Title, movie_rating = :Rating
                WHERE movie_id = :ID
            ");
            //Bind data to SQL
            $sql->bindValue(":Title", $movie_title);
            $sql->bindValue(":Rating", $movie_rating);
            $sql->bindValue(":ID", $movie_id);
            //Execute the statement.
            $sql->execute();

            //exit('DB Success.');

            //Redirect to list.php
            header("Location:list.php?success=1");



        }catch (PDOException $e) {echo "DATABASE ERROR: " . $e->getMessage(); exit;}
    }
    else if(isset($_POST) && !empty($_POST))
    {
        $error = "Please insert both a title and rating before submitting.";
    }
?>


<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Update Movie</title>
    <link rel="stylesheet" type="text/css" href="../css/style.css" />

    <script type="text/javascript">
        //SOME JAVASCRIPT CODE
        function DeleteMovie (movieName, id)
        {
            //A quick Yes/No box to check if they really want to delete this.
            if(confirm("Do you really wish to delete " + movieName + "?"))
            {
                document.location.href = "delete.php?id="+ id;
            }
        }

    </script>
</head>
<body>
<header>
    <?php include ('../template/header.php'); ?>
</header>
<nav>
    <?php include ('../template/nav.php'); ?>
</nav>
<main>
    <form method="POST">

        <!--A hidden form input to hold our id for safe keeping.-->
        <input type="hidden" name="movie_id" id="movie_id" value="<?= $id ?>"

        <?php if(isset($error)) { ?>
            <p class="error"><?= $error ?></p>
        <?php } ?>
        <!--Not best practice. But works.-->
        <table border="1" width="60%">
        <tr height="100">
            <th colspan="2">Update Movie Record</th>
        </tr>
            <tr height="50">
                <th>
                    Movie Name
                </th>
                <td>
                    <input type="text" name="movie_name" id="movie_name" value="<?= $title ?>"  />
                </td>
            </tr>
            <tr height="50">
                <th>
                    Movie Rating
                </th>
                <td>
                    <input type="text" name="movie_rating" id="movie_rating" maxlength="5" value="<?= $rating ?>"  />
                </td>
            </tr>
            <tr height="100">
                <td colspan="2">
                    <input type="submit" name="movie_submit" id="movie_submit" value="Update Movie" />
                    <input type="button" name="moive_delete" id="movie_delete" value="Delete Movie" onclick="DeleteMovie('<?= $title ?>','<?= $id ?>')" />
                </td>
            </tr>
        </table>

    </form>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>