<?php

//Database connection
include('../template/db_conn.php');

try
{
    //Call the database
    $db = new PDO($db_dsn,$db_username,$db_password,$db_options);
    //Select * data from the table.
    $sql = $db->prepare("SELECT * FROM phpclass.customer_listing;");
    //Database Executes the order.
    $sql->execute();
    //Deliver the data to $rows
    $rows = $sql->fetchAll();


}catch(PDOException $e){ echo $e->getMessage(); exit;}

?>



<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Customer List</title>
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
    <h1 class="center">Customer Listing</h1>
    <?php if(isset($_GET['success'])) { ?>
        <p class="success">Customer Add/Update Success!</p>
    <?php } ?>
    <?php if(isset($_GET['delete']) && $_GET['delete'] == '1') { ?>
        <p class="success">Customer was deleted successfully!</p>
    <?php }else if(isset($_GET['delete']) && $_GET['delete'] == '0'){ ?>
        <p class="error">Customer was not deleted properly. Please try again.</p>
    <?php } ?>
    <table width="100%" border="1" width="65%">

        <tr>
            <th>ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>ZIP</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Password</th>
        </tr>

        <?php foreach($rows as $customer) : ?>
            <tr>
                <td><a href="updateCustomer.php?id=<?= $customer['customer_id']?>"><?= $customer['customer_id'] ?></a></td>
                <td><?= $customer['first_name'] ?></td>
                <td><?= $customer['last_name'] ?></td>
                <td><?= $customer['address'] ?></td>
                <td><?= $customer['city'] ?></td>
                <td><?= $customer['state'] ?></td>
                <td><?= $customer['zip'] ?></td>
                <td><?= $customer['phone'] ?></td>
                <td><?= $customer['email'] ?></td>
                <td><?= $customer['password'] ?></td>
                <!--<td>Secret</td>-->

            </tr>
        <?php endforeach; ?>

    </table>

    <p class="center"><a href="addCustomer.php">Add New Customer</a></p>
</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>