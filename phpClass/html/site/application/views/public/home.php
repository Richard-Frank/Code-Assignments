<?php
    //<?=asset_url() is a shortcut helper to the asset folder.

    //Some images are referenced in their .css files.
?>


<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Runner's Software Pro</title>

    <!-- Bootstrap Core CSS -->
    <link href="<?=asset_url()?>css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="<?=asset_url()?>css/landing-page.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="<?=asset_url()?>font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    <?php
    if(isset($load_error))
    {
        unset($load_error);
        echo "<script>window.onload=function() {location.href='#login'} </script>";
    }
    if(isset($account_made))
    {
        unset($account_made);
        echo "<script>window.onload=function() {location.href='#login'} </script>";
    }
    ?>

</head>

<body>

    <!-- Navigation -->
    <nav class="navbar navbar-default navbar-fixed-top topnav" role="navigation">
        <div class="container topnav">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand topnav" href="#">Runner's Software Pro</a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a href="#about">About</a>
                    </li>
                    <li>
                        <a href="#services">Services</a>
                    </li>
                    <li>
                        <a href="#login">Login</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>


    <!-- Header -->
    <a name="about"></a>
    <div class="intro-header">
        <div class="container">

            <div class="row">
                <div class="col-lg-12">
                    <div class="intro-message">
                        <h1>Runner's Software Master</h1>
                        <h3>Speeding you up, so you can keep pace.</h3>
                    </div>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.intro-header -->

    <!-- Page Content -->

	<a  name="services"></a>
    <div class="content-section-a">

        <div class="container">
            <div class="row">
                <div class="col-lg-5 col-sm-6">
                    <hr class="section-heading-spacer">
                    <div class="clearfix"></div>
                    <h2 class="section-heading">Quick and Easy Software Management</h2>
                    <p class="lead">Our software is streamlined and built for ease of use. Providing minimal resistance while maximizing your ability to quickly meet your goals.</p>
                </div>
                <div class="col-lg-5 col-lg-offset-2 col-sm-6">
                    <img class="img-responsive" src="<?=asset_url()?>img/computer-work.jpg" alt="">
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.content-section-a -->

    <div class="content-section-b">

        <div class="container">

            <div class="row">
                <div class="col-lg-5 col-lg-offset-1 col-sm-push-6  col-sm-6">
                    <hr class="section-heading-spacer">
                    <div class="clearfix"></div>
                    <h2 class="section-heading">Open API for Developers</h2>
                    <p class="lead">Our open API ensures that you and your developers always have access to the exact software that works for you, available when are where you need it.</p>
                </div>
                <div class="col-lg-5 col-sm-pull-6  col-sm-6">
                    <img class="img-responsive" src="<?=asset_url()?>img/computer-code.jpg" alt="">
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.content-section-b -->

    <div class="content-section-a">

        <div class="container">

        <div class="row">
            <div class="col-lg-5 col-sm-6">
                <hr class="section-heading-spacer">
                <div class="clearfix"></div>
                <h2 class="section-heading">Interface That Plugs Directly Into Your Site</h2>
                <p class="lead">Our modular, plug and run software, ensures that you are able to set up the system that you need in the time that you need it. </p>
            </div>
            <div class="col-lg-5 col-lg-offset-2 col-sm-6">
                <img class="img-responsive" src="<?=asset_url()?>img/puzzle.jpg" alt="">
            </div>
        </div>

    </div>
    <!-- /.container -->

    </div>
    <!-- /.content-section-a -->

    <div class="content-section-b">

        <div class="container">

            <div class="row">
                <div class="col-lg-5 col-lg-offset-1 col-sm-push-6  col-sm-6">
                    <hr class="section-heading-spacer">
                    <div class="clearfix"></div>
                    <h2 class="section-heading">Cost Effective Software</h2>
                    <p class="lead">Our specialized software ensures that you are always getting the most value for your dollar. Don't pay for anything you don't need.</p>
                </div>
                <div class="col-lg-5 col-sm-pull-6  col-sm-6">
                    <img class="img-responsive" src="<?=asset_url()?>img/money.jpg" alt="">
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.content-section-b -->

    <a  name="login"></a>
    <div class="content-section-a">

        <div class="container">

            <div class="row">
                <div class="col-lg-10 col-sm-12">
                    <?= validation_errors('<p class="text-danger">') ?>
                    <?php

                        if(isset($error_message))
                        {
                          echo "<p class='text-danger'>". $error_message ."</p>";

                        }
                        if(isset($confirmation_message))
                        {
                            echo "<p>". $confirmation_message ."</p>";
                        }
                    ?>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-4 col-sm-5">
                    <h3>Login</h3>

                    <?php
                    //Requires loading the form-helper in the Home.php controller.
                        //Form builder

                        echo form_open('home/login');
                        //Enter a name, placeholder-value, and additional details(Max length etc.),
                        //Same as <input type="text" name="user_name" placeholder="Username" Value="" />
                        echo form_input('user_name', '', 'placeholder="Username"');

                        echo "<br/>";

                        echo form_password('user_password', '', 'placeholder="Password"');

                        echo "<br/>";

                        echo form_submit('login_submit', 'Login', '');

                        echo form_close();
                    ?>

                </div>
                <div class="col-lg-1 col-sm-1"></div>
                <div class="col-lg-4 col-lg-offset-2 col-sm-5">
                    <h3>Create a new account</h3>
                    <?php
                    //Requires loading the form-helper in the Home.php controller.
                    //Form builder
                    echo form_open('home/create');

                    echo form_input('new_user_name', '', 'placeholder="Username@email.com"');

                    echo "<br/>";

                    echo form_input('new_full_name', '', 'placeholder="Full Name"');

                    echo "<br/>";
                    echo "<br/>";

                    echo form_password('new_user_password', '', 'placeholder="Password"');

                    echo "<br/>";

                    echo form_password('confirm_password', '', 'placeholder="Confirm Password"');

                    echo "<br/>";

                    echo form_submit('login_submit', 'Register Account', '');

                    echo form_close();
                    ?>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.content-section-a -->

    <!-- Footer -->
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <ul class="list-inline">
                        <li>
                            <a href="#">Home</a>
                        </li>
                        <li class="footer-menu-divider">&sdot;</li>
                        <li>
                            <a href="#about">About</a>
                        </li>
                        <li class="footer-menu-divider">&sdot;</li>
                        <li>
                            <a href="#services">Services</a>
                        </li>
                        <li class="footer-menu-divider">&sdot;</li>
                        <li>
                            <a href="#login">Login</a>
                        </li>
                    </ul>
                    <p class="copyright text-muted small">&copy; RF-LLC 2022. All Rights Reserved</p>
                </div>
            </div>
        </div>
    </footer>

    <!-- jQuery -->
    <script src="<?=asset_url()?>js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="<?=asset_url()?>js/bootstrap.min.js"></script>

</body>

</html>
