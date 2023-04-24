<?php
//Validate if the input text inputs are filled out and not empty.
if(isset($_POST['first_name']) && !empty($_POST['first_name'])
    && isset($_POST['last_name']) && !empty($_POST['last_name'])
    && isset($_POST['address']) && !empty($_POST['address'])
    && isset($_POST['city']) && !empty($_POST['city'])
    && isset($_POST['state']) && !empty($_POST['state'])
    && isset($_POST['zip']) && !empty($_POST['zip'])
    && isset($_POST['phone']) && !empty($_POST['phone'])
    && isset($_POST['email']) && !empty($_POST['email'])
    && isset($_POST['password']) && !empty($_POST['password']))
{
    //Prints out the POSTed data for debugging.
    //echo "<pre>";
    //print_r($_POST);
    //echo "</pre>";

    if ($_POST['password'] === $_POST['verify_pass']) {
        //Set the variables with data from the text inputs.
        $first_name = $_POST['first_name'];
        $last_name = $_POST['last_name'];
        $address = $_POST['address'];
        $city = ($_POST['city']);
        $state = strtoupper($_POST['state']);
        $zip = $_POST['zip'];
        $phone = $_POST['phone'];
        $email = $_POST['email'];
        $password = $_POST['password'];



        //DATABASE STUFF

        //Connection
        include('../template/db_conn.php');

        try
        {
            //Check for duplicate emails.
            $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
            $sql = $db->prepare("
                SELECT customer_id FROM phpclass.customer_listing WHERE email = :Email  
            ");
            $sql->bindValue(':Email', $email);
            $sql->execute();
            $row = $sql->fetch();

            if($row != false)
            {//Duplicate found.
                $error = $email." is already registered to an account.";
            }
        }catch(PDOException $e){echo $e->getMessage(); exit;}

        //Get the data from the text inputs, submits to database.
        if(empty($error))
        {
            try {

                ////////////
                //Hard coded GUID generation
                $member_key = sprintf('%04X%04X%04X%04X%04X%04X%04X%04X',
                    mt_rand(0, 65535),
                    mt_rand(0, 65535),
                    mt_rand(0, 65535),
                    mt_rand(16384, 20479),
                    mt_rand(32768, 49151),
                    mt_rand(0, 65535),
                    mt_rand(0, 65535),
                    mt_rand(0, 65535));
                /////////////


                $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
                $sql = $db->prepare("
                        INSERT INTO
                        phpclass.customer_listing(first_name, last_name, address, city, state, zip, phone, email, password, member_key)
                        VALUE (:firstName, :lastName, :Address, :City, :State, :Zip, :Phone, :Email, :Password, :MemberKey)
                    ");
                //Bind data to SQL
                $sql->bindValue(":firstName", $first_name);
                $sql->bindValue(":lastName", $last_name);
                $sql->bindValue(":Address", $address);
                $sql->bindValue(":City", $city);
                $sql->bindValue(":State", $state);
                $sql->bindValue(":Zip", $zip);
                $sql->bindValue(":Phone", $phone);
                $sql->bindValue(":Email", $email);
                $sql->bindValue(":Password", md5($password.$member_key));
                $sql->bindValue(":MemberKey", $member_key);

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
}
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Create New Customer</title>
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
    <h1 class="center">Create New Account</h1>
    <?php if(isset($error)) { ?>
        <p class="error"><?= $error ?></p>
    <?php } ?>
    <div id="addcustomer">
        <form method="post" id="form">
            <fieldset>
                <legend class="frmcustomer">Customer</legend>
                <ul>
                    <li>
                        <label for="first_name">First Name: </label>
                        <input type="text" id="first_name" name="first_name" required>
                    </li>
                    <li>
                        <label for="last_name">Last Name: </label>
                        <input type="text" id="last_name" name="last_name" required>
                    </li>
                    <li>
                        <label for="phone"> Phone: </label>
                        <input type="tel" id="phone" name="phone" pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}" placeholder="111-222-3333" maxlength="12" required>
                    </li>
                    <li>
                        <label for="email">Email: </label>
                        <input type="email" id="email" name="email" placeholder="example@email.com" required>
                    </li>
                </ul>
            </fieldset>
            <fieldset>
                <legend class="frmaddress">Address</legend>
                <ul>
                    <li>
                        <label for="address">Address: </label>
                        <input type="text" id="address" name="address" required>
                    </li>
                    <li>
                        <label for="city">City: </label>
                        <input type="text" id="city" name="city" required>
                    </li>
                        <li>
                            <label for="zip">ZIP: </label>
                            <input type="text" id="zip" name="zip" pattern="[0-9\-]{5,10}" placeholder="12345-1234" maxlength="10" minlength="5" required>
                        </li>
                    <li>
                        <label for="state">State: </label>
                        <input type="text" id="state" name="state" maxlength="2" pattern="[A-Za-z]{2}"  placeholder="WI" required>
                    </li>
                </ul>
            </fieldset>

            <fieldset>
                <legend class="frmsecurity">Security</legend>
                <ul>
                    <li>
                        <label for="password">Password: </label>
                        <input type="password" id="password" name="password" required>
                    </li>
                    <li>
                        <label for="verify_pass">Verify Password: </label>
                        <input type="password" id="verify_pass" name="verify_pass" placeholder="Verify Password" required>
                    </li>
                </ul>
            </fieldset>
            <input type="submit" name="customer_submit" id="customer_submit" value="submit">
            <input type="reset" value="Reset">
        </form>
    </div>


</main>
<footer>
    <?php include ('../template/footer.php'); ?>
</footer>
</body>
</html>