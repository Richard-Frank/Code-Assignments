<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>RSM - Add Marathon</title>

    <!-- Bootstrap Core CSS -->
    <link href="<?= asset_url() ?>css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="<?= asset_url() ?>css/sb-admin.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="<?= asset_url() ?>font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>

    <div id="wrapper">

        <!-- Navigation -->
        <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <?php
            //Load the navigation menus.
            $this->load->view('includes/header');
            $this->load->view('includes/menu');
            ?>
        </nav>

        <div id="page-wrapper">

            <div class="container-fluid">

                <div class="row">
                    <h2>Add Marathon</h2>
                    <div class="col-lg-12">

                        <form role="form" method="POST" action="/site/admin/add_race">
                            <div class="form-group">
                                <label>Race Name</label>
                                <input name="txt_name" class="form-control">
                            </div>
                            <div class="form-group">
                                <label>Race Location</label>
                                <input name="txt_location" class="form-control">
                            </div>
                            <div class="form-group">
                                <label>Race Description</label>
                                <textarea name="txt_description" class="form-control" placeholder="5k race from X to Y."></textarea>
                            </div>
                            <!--
                            <div class="form-group">
                                <label>Race Date & Time</label>
                                <input name="txt_date" class="form-control" placeholder="2022-04-16 13:30:00">
                            </div>
                            -->
                            <div class="form-group">
                                <label>Date&Time</label>
                                <input name="txt_date" type="datetime-local" class="form-control">
                            </div>

                            <button type="submit" class="btn btn-primary">Submit</button>
                            <button type="reset" class="btn btn-default">Reset</button>

                        </form>

                    </div>
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="<?= asset_url() ?>js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="<?= asset_url() ?>js/bootstrap.min.js"></script>

</body>

</html>
