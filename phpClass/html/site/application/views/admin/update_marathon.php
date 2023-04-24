<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>RSM - Update Marathon</title>

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
            //echo $race[0]['race_date_time'];exit();
            //Load the navigation menus.
            $this->load->view('includes/header');
            $this->load->view('includes/menu');


            ?>
        </nav>

        <div id="page-wrapper">

            <div class="container-fluid">

                <div class="row">
                    <h2>Update Marathon</h2>
                    <?php
                        $oldtime = $race[0]['race_date_time'];
                        $time = substr_replace($oldtime, 'T', 10) . substr($oldtime, 11);

                    ?>
                    <div class="col-lg-12">

                        <form role="form" method="POST" action="/site/admin/edit_race">
                            <input type="hidden" name="txt_id" value="<?= $race[0]['race_id']; ?>">
                            <div class="form-group">
                                <label>Race Name</label>
                                <input name="txt_name" class="form-control" value="<?= $race[0]['race_name']; ?>">
                            </div>
                            <div class="form-group">
                                <label>Race Location</label>
                                <input name="txt_location" class="form-control" value="<?= $race[0]['race_location']; ?>">
                            </div>
                            <div class="form-group">
                                <label>Race Description</label>
                                <textarea name="txt_description" class="form-control" placeholder="5k race from X to Y."><?= $race[0]['race_description']; ?></textarea>
                            </div>
                            <!--
                            <div class="form-group">
                                <label>Race Date & Time</label>
                                <input name="txt_date" class="form-control" placeholder="2022-04-16 13:30:00" value="$race[0]['race_description']"
                            </div>
                            -->
                            <div class="form-group">
                                <label>Date&Time</label>
                                <input name="txt_date" type="datetime-local" class="form-control" autocomplete="" value="<?= $time//$race[0]['race_date_time']; ?>">
                            </div>

                            <button type="submit" class="btn btn-primary">Update Race</button>

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
