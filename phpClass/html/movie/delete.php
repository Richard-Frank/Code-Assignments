<?php

    if(isset($_GET['id']) && !empty($_GET['id']) && filter_var($_GET['id'], FILTER_VALIDATE_INT) )
    {
        //Database connection
        include "../template/db_conn.php";

        $id = $_GET['id'];
        //echo $id; exit;

        try
        {
            $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
            $sql = $db->prepare("
                DELETE FROM phpclass.movielist WHERE movie_id = :ID
            ");
            $sql->bindValue(':ID', $id);
            $sql->execute();

        }catch(PDOException $e) {$e->getMessage(); exit; }

        header("Location: list.php?delete=1");
        exit;
    }
    header("Location: list.php?delete=0");


?>