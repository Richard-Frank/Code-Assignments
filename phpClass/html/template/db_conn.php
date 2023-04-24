<?php

    //Connection String
    $db_dsn = "mysql:host=localhost;dbname=phpclass";
    //Username
    $db_username = "dbuser";
    //Password
    $db_password = "dbdev123";
    //Options | PDO - PHP Data Object
    $db_options = [pdo::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,];