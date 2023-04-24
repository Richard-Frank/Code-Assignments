<?php
//Start the session
session_start();
//Sessions are set for a fixed amount of time. This resets it.
if (isset($_SESSION['UID']))
{
    unset($_SESSION['UID']);
    $error = "Admin user has been logged out";
}


//Validate if the input text inputs are filled out and not empty.
if(isset($_POST['txt_email']) && !empty($_POST['txt_email'])
    && isset($_POST['txt_password']) && !empty($_POST['txt_password']))
{
    //Set the variables with data from the text inputs.
    $user_email = strtolower($_POST['txt_email']);
    $user_password = $_POST['txt_password'];


    //LOGIN STUFF
    include('../template/db_conn.php');
    try
    {
        $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
        $sql = $db->prepare("
            SELECT
            password, role_id, member_key
            FROM 
            phpclass.member_login
            WHERE
            email = :Email
        ");
        $sql->bindValue(':Email', $user_email);
        $sql->execute();

        $row = $sql->fetch();
        //Debug
        //echo ('<pre>'); var_dump($row); echo ('<pre>'); exit;

        if($row !== false)
        {//Validate the password
            $hashed_password = md5($user_password.$row['member_key']);

            if($hashed_password == $row['password'] && $row['role_id'] == 1)
            {//Checks the input against the hashed password, and checks to see if they are admin.

                //Sets session to Admin.
                $_SESSION['UID'] = $row['member_key'];
                $_SESSION['ROLE'] = $row['role_id'];
                header("Location:admin.php");
            }
            else if($hashed_password == $row['password'] && $row['role_id'] !== 1)
            {//Checks input against hashed password, and checks to sends them to member page.

                $_SESSION['UID'] = $row['member_key'];
                $_SESSION['ROLE'] = $row['role_id'];
                header("Location:member.php");
            }
            else
            {//Invalid password.
                $error = "Invalid username or password. PASSWORD";
            }

        }
        else
        {//Invalid email.
            $error = "Invalid username or password. EMAIL";
        }


    }catch(PDOException $e){echo $e->getMessage(); exit;}




    /* HARDCODED LOGIN CHECK
    if($user_email == 'admin@admin' && $user_password == "p@ss")
    {

        //Set the session to Admin.
        $_SESSION['UID'] = 1;
        header("Location:admin.php");
    }
    else if($user_email == 'member@member' && $user_password == "p@ss")
    {
        header("Location:member.php");

    } else
    {
        $error = "Please enter a valid Email and Password";
    }
    */
}
else if(isset($_POST) && !empty($_POST))
{
    $error = "Please enter a valid Email and Password.";
}
?>


<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Login Form</title>
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
                <th colspan="2">Login</th>
            </tr>
            <tr height="50">
                <th>
                    Email
                </th>
                <td>
                    <input type="email" name="txt_email" id="txt_email" value="<?= $user_email ?>"  />
                </td>
            </tr>
            <tr height="50">
                <th>
                    Password
                </th>
                <td>
                    <input type="password" name="txt_password" id="txt_password" value="<?= $user_password ?>"  />
                </td>
            </tr>
            <tr height="100">
                <td colspan="2">
                    <input type="submit" name="login_submit" id="login_submit" value="Login" />
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