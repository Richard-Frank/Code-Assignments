<?php

    //Check to see if we passed the id, and if it is the valid type.
    if(isset($_GET['id']) && !empty($_GET['id']) && filter_var($_GET['id'], FILTER_VALIDATE_INT) )
    {
        $id = $_GET['id'];

        try
        {
            //Connection
            include('../template/db_conn.php');
            $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
            $sql = $db->prepare("
                SELECT * FROM phpclass.customer_listing WHERE customer_id = :ID
            ");
            $sql->bindValue(':ID', $id);
            $sql->execute();
            //Get the data
            $row = $sql->fetch();

            if(!$row)
            {//Does a quick bool check to see if row is empty, if it is, kick them to list page.
                header("Location: customerList.php");
            }
            //Bind the data to local variables.
            $first_name = $row['first_name'];
            $last_name = $row['last_name'];
            $address = $row['address'];
            $city = ($row['city']);
            $state = $row['state'];
            $zip = $row['zip'];
            $phone = $row['phone'];
            $email = $row['email'];
            $password = $row['password'];
            $member_key = $row['member_key'];


        }catch(PDOException $e) {$e->getMessage(); exit;}
    }






//Validate if the input text inputs are filled out and not empty.
if(isset($_POST['customer_first_name']) && !empty($_POST['customer_first_name'])
    && isset($_POST['customer_last_name']) && !empty($_POST['customer_last_name'])
    && isset($_POST['customer_address']) && !empty($_POST['customer_address'])
    && isset($_POST['customer_city']) && !empty($_POST['customer_city'])
    && isset($_POST['customer_state']) && !empty($_POST['customer_state'])
    && isset($_POST['customer_zip']) && !empty($_POST['customer_zip'])
    && isset($_POST['customer_phone']) && !empty($_POST['customer_phone'])
    && isset($_POST['customer_email']) && !empty($_POST['customer_email'])
    && isset($_POST['customer_password']) && !empty($_POST['customer_password'])
    && isset($_POST['customer_id']) && !empty($_POST['customer_id']))
{
    //Prints out the POSTed data for debugging.
    //echo "<pre>";
    //print_r($_POST);
    //echo "</pre>";

    if ($_POST['customer_password'] === $_POST['verify_pass']) {
        //Set the variables with data from the text inputs.
        //Customer id and Member key are passed as hidden inputs.
        $customer_id = $_POST['customer_id'];
        $customer_first_name = $_POST['customer_first_name'];
        $customer_last_name = $_POST['customer_last_name'];
        $customer_address = $_POST['customer_address'];
        $customer_city = ($_POST['customer_city']);
        $customer_state = strtoupper($_POST['customer_state']);
        $customer_zip = $_POST['customer_zip'];
        $customer_phone = $_POST['customer_phone'];
        $customer_email = $_POST['customer_email'];
        $customer_password = $_POST['customer_password'];
        $customer_key = $_POST['customer_key'];

        try
        {
            //Check for duplicate emails.
            $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
            $sql = $db->prepare("
                SELECT customer_id FROM phpclass.customer_listing WHERE email = :Email  
            ");
            $sql->bindValue(':Email', $customer_email);
            $sql->execute();
            $row = $sql->fetch();

            if($row['customer_id'] !== $customer_id && !empty($row))
            {//Duplicate found.
                $error = $customer_email." is already registered to an account.";
            }
        }catch(PDOException $e){echo $e->getMessage(); exit;}

        if (empty($error))
        {
            //Get the data from the text inputs, submits to database.
            try {

                $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
                $sql = $db->prepare("
                UPDATE phpclass.customer_listing SET
                first_name = :firstName,
                last_name = :lastName,
                address = :Address,
                city = :City,
                state = :State,
                zip = :Zip,
                phone = :Phone,
                email = :Email,
                password = :Password
                WHERE customer_id = :ID
                ");
                //Bind data to SQL
                $sql->bindValue(":ID", $customer_id);
                $sql->bindValue(":firstName", $customer_first_name);
                $sql->bindValue(":lastName", $customer_last_name);
                $sql->bindValue(":Address", $customer_address);
                $sql->bindValue(":City", $customer_city);
                $sql->bindValue(":State", $customer_state);
                $sql->bindValue(":Zip", $customer_zip);
                $sql->bindValue(":Phone", $customer_phone);
                $sql->bindValue(":Email", $customer_email);
                $sql->bindValue(":Password", md5($customer_password.$customer_key));

                //Execute the statement.
                $sql->execute();

                //Redirect to the customer listing page
                header("Location:customerList.php?success=1");

            } catch (PDOException $e) {
                echo "DATABASE ERROR: " . $e->getMessage();
                exit;
            }
        }

    }else if (isset($_POST) && !empty($_POST)) {
        $error = "Your passwords did not match!";
    }
}
else if (isset($_POST) && !empty($_POST)) {
    $error = "Please enter all required data.";
    //echo "<pre>";
    //print_r($_POST);
    //echo "</pre>";
}
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Update Customer</title>
    <link rel="stylesheet" type="text/css" href="../css/style.css" />

    <script type="text/javascript">
        //JAVASCRIPT STUFF
        function DeleteCustomer(firstName, lastName, Id)
        {
            if(confirm("Do you really wish to delete " + firstName + " " + lastName + "?"))
            {
                document.location.href = "deleteCustomer.php?id="+ Id;
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
    <h1 class="center">Update Account</h1>
    <?php if(isset($error)) { ?>
        <p class="error"><?= $error ?></p>
    <?php } ?>
    <div id="addcustomer">
        <form method="post" id="form">

            <input type="hidden" id="customer_id" name="customer_id" value="<?= $id ?>">
            <input type="hidden" id="customer_key" name="customer_key" value="<?= $member_key?>">

            <fieldset>
                <legend class="frmcustomer">Customer</legend>
                <ul>
                    <li>
                        <label for="first_name">First Name: </label>
                        <input type="text" id="customer_first_name" name="customer_first_name" value="<?= $first_name ?>" required>
                    </li>
                    <li>
                        <label for="last_name">Last Name: </label>
                        <input type="text" id="customer_last_name" name="customer_last_name" value="<?= $last_name ?>" required>
                    </li>
                    <li>
                        <label for="phone"> Phone: </label>
                        <input type="tel" id="customer_phone" name="customer_phone" value="<?= $phone ?>" pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}" placeholder="111-222-3333" maxlength="12" required>
                    </li>
                    <li>
                        <label for="email">Email: </label>
                        <input type="email" id="customer_email" name="customer_email" value="<?= $email ?>" placeholder="example@email.com" required>
                    </li>
                </ul>
            </fieldset>
            <fieldset>
                <legend class="frmaddress">Address</legend>
                <ul>
                    <li>
                        <label for="address">Address: </label>
                        <input type="text" id="customer_address" name="customer_address" value="<?= $address ?>" required>
                    </li>
                    <li>
                        <label for="city">City: </label>
                        <input type="text" id="customer_city" name="customer_city" value="<?= $city ?>" required>
                    </li>
                        <li>
                            <label for="zip">ZIP: </label>
                            <input type="text" id="customer_zip" name="customer_zip" value="<?= $zip ?>" pattern="[0-9\-]{5,10}" placeholder="12345-1234" maxlength="10" minlength="5" required>
                        </li>
                    <li>
                        <label for="state">State: </label>
                        <input type="text" id="customer_state" name="customer_state" value="<?= $state ?>" maxlength="2" pattern="[A-Za-z]{2}"  placeholder="WI" required>
                    </li>
                </ul>
            </fieldset>

            <fieldset>
                <legend class="frmsecurity">Security</legend>
                <ul>
                    <li>
                        <label for="password">Password: </label>
                        <input type="password" id="customer_password" name="customer_password" required>
                    </li>
                    <li>
                        <label for="verify_pass">Verify Password: </label>
                        <input type="password" id="verify_pass" name="verify_pass" placeholder="Verify Password" required>
                    </li>
                </ul>
            </fieldset>
            <input type="submit" name="customer_submit" id="customer_submit" value="submit">
            <input type="reset" value="Reset">
            <input type="button" name="btnDelete" id="btnDelete" value="Delete" onclick="DeleteCustomer('<?= $first_name ?>', '<?= $last_name ?>','<?= $id ?>')" >
        </form>
    </div>


</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>