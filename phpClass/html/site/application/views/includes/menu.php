<!-- Sidebar Menu Items - These collapse to the responsive navigation menu on small screens -->
<div class="collapse navbar-collapse navbar-ex1-collapse">
    <ul class="nav navbar-nav side-nav">
        <li
            <?php //Long form if statement
            if (isset($dashboard))
            {
                echo ' class="active"';
            }
            ?>
        >
            <a href="/site/admin"><i class="fa fa-fw fa-dashboard"></i> Dashboard</a>
        </li>
        <li <?= isset($add_marathon) ? "class='active'" : "" //Short form if statement?>>
            <a href="/site/admin/add_marathon"><i class="fa fa-fw fa-plus"></i> Add Marathon</a>
        </li>
        <li <?= isset($manage_marathons) ? "class='active'" : "" ?> >
            <a href="/site/admin/manage_marathons"><i class="fa fa-fw fa-wrench"></i> Manage Marathons</a>
        </li>
        <li <?= isset($manage_runners) ? "class='active'" : "" ?>>
            <a href="/site/admin/manage_runners"><i class="fa fa-fw fa-wrench"></i> Manage Runners</a>
        </li>
        <li <?= isset($registration_form) ? "class='active'" : "" ?>>
            <a href="/site/admin/registration_form"><i class="fa fa-fw fa-edit"></i> Registration Form</a>
        </li>
    </ul>
</div>