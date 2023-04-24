<?php
session_start();
//Debug, check the session variable.
//print_r($_SESSION); exit;

//Check the session for valid admin variable.
if($_SESSION['ROLE'] != 1)
{
    //If the role is invalid, kick the user back to login.
    header("Location:index.php");
}
$error = [];


//Get data to populate controls.
include ('../template/db_conn.php');
try
{
    $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
    //Get runner data by race id.
    $sql = $db->prepare("SELECT * FROM phpclass.member_roles");
    $sql->execute();
    $roles = $sql->fetchAll();

    if($roles == null)
    {
        $error[] = "Error generating member roles.";
    }
}
catch(PDOException $e)
{//Create an errors array, and spit it out in Json
    echo $e->getMessage();
}

//Data validations
if(isset($_POST['user_submit']))
{//See also: switch statement.
    if (isset($_POST['txt_name']) && !empty($_POST['txt_name']))
    {
        $fullname = $_POST['txt_name'];
    }else { $error[] = "Name is required!"; }
    if (isset($_POST['txt_email']) && !empty($_POST['txt_email']))
    {
        $email = $_POST['txt_email'];
    }else { $error[] = "Email is required!"; }
    if (isset($_POST['txt_password']) && !empty($_POST['txt_password']))
    {
        $password = $_POST['txt_password'];
    }else { $error[] = "Password is required!"; }
    if($password != $_POST['txt_verify_password'])
    {
        $error[] = "Passwords must match!";
    }
    else
    {
        $verify_password = $_POST['txt_verify_password'];
    }
    if (isset($_POST['txt_role']) && !empty($_POST['txt_role']))
    {
        $role = $_POST['txt_role'];
    }else { $error[] = "Role is required! How did you manage that?"; }


    //After validation gauntlet

    //include ('../template/db_conn.php');
    try
    {
        //Check for duplicate emails.
        $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
        $sql = $db->prepare("
                SELECT member_id FROM phpclass.member_login WHERE email = :Email  
            ");
        $sql->bindValue(':Email', $email);
        $sql->execute();
        $row = $sql->fetch();

        if($row != false)
        {//Duplicate found.
            $error[] = $email." is already registered to an account.";
        }
    }catch(PDOException $e){echo $e->getMessage(); exit;}
    if (empty($error))
    {
        try
        {

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
            //Prepare the SQL
            $sql = $db->prepare("
                INSERT INTO phpclass.member_login
                (name, email, role_id, password, member_key)
                 VALUE (:MemberName, :Email, :RoleID, :Password, :MemberKey)
            ");
            $sql->bindValue(':MemberName', $fullname);
            $sql->bindValue(':Email', $email);
            $sql->bindValue('RoleID', $role);
            $sql->bindValue(':Password', md5($password.$member_key));
            $sql->bindValue(':MemberKey', $member_key);

            $sql->execute();

            $error[] = "New User has been registered.";
            unset($fullname, $email, $role, $password, $verify_password);

        }catch(PDOException $e) {$e->getMessage(); exit;}
    }
}


?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Admin</title>
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
    <h1 class="center">Admin Page</h1>

    <form method="POST">
        <?php if(isset($error) && !empty($error)) { ?>
                <?php foreach($error as $e) : ?>
                <p class="error"><?= $e ?></p>
                <?php endforeach; ?>
        <?php } ?>
        <!--Not best practice. But works.-->
        <table border="1" width="60%">
            <tr height="100">
                <th colspan="2">User Registration</th>
            </tr>

            <tr height="50">
                <th>
                    Full Name
                </th>
                <td>
                    <input type="text" name="txt_name" id="txt_name" value="<?= $fullname ?>"  />
                </td>
            </tr>
            <tr height="50">
                <th>
                    Email
                </th>
                <td>
                    <input type="email" name="txt_email" id="txt_email" value="<?= $email ?>"  />
                </td>
            </tr>
            <tr height="50">
                <th>
                    Role
                </th>
                <td>
                    <select name="txt_role" id="txt_role">
                    <? foreach($roles as $role) : ?>
                        <option value= <?= $role['role_id']?> ><?= $role["role_value"]; ?></option>
                    <?php endforeach; ?>
                    </select>
                </td>
            </tr>
            <tr height="50">
                <th>
                    Password
                </th>
                <td>
                    <input type="password" name="txt_password" id="txt_password" value="<?= $password ?>"  />
                </td>
            </tr>
            <tr height="50">
                <th>
                    Verify Password
                </th>
                <td>
                    <input type="password" name="txt_verify_password" id="txt_verify_password" value="<?= $verify_password ?>"  />
                </td>
            </tr>
            <tr height="100">
                <td colspan="2">
                    <input type="submit" name="user_submit" id="user_submit" value="Create User" />
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