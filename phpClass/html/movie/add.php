<?php
    //Validate if the input text inputs are filled out and not empty.
    if(isset($_POST['movie_name']) && !empty($_POST['movie_name'])
        && isset($_POST['movie_rating']) && !empty($_POST['movie_rating']))
    {
        //Prints out the POSTed data for debugging.
        //echo "<pre>"; print_r($_POST); echo "</pre>";

        //Set the variables with data from the text inputs.
        $title = $_POST['movie_name'];
        $rating = $_POST['movie_rating'];

        //DATABASE STUFF

        //Connection
        include ('../template/db_conn.php');

        //Get the data from the text inputs, submits to database.
        try
        {
            $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
            $sql = $db->prepare("
                INSERT INTO
                phpclass.movielist(movie_title, movie_rating)
                VALUE (:Title, :Rating)
            ");
            //Bind data to SQL
            $sql->bindValue(":Title", $title);
            $sql->bindValue(":Rating", $rating);
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
    <title>Add Movie</title>
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
    <form method="POST">
        <?php if(isset($error)) { ?>
            <p class="error"><?= $error ?></p>
        <?php } ?>
        <!--Not best practice. But works.-->
        <table border="1" width="60%">
        <tr height="100">
            <th colspan="2">Add New Movie to Database</th>
        </tr>
            <tr height="50">
                <th>
                    Movie Name
                </th>
                <td>
                    <input type="text" name="movie_name" id="movie_name"  />
                </td>
            </tr>
            <tr height="50">
                <th>
                    Movie Rating
                </th>
                <td>
                    <input type="text" name="movie_rating" id="movie_rating" maxlength="5"  />
                </td>
            </tr>
            <tr height="100">
                <td colspan="2">
                    <input type="submit" name="movie_submit" id="movie_submit" value="Add Movie" />
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