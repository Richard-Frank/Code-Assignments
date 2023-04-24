<?php
//Basically a using statement.
require "Slim/Slim.php";

//Register the auto-loader
\Slim\Slim::registerAutoloader();

/*
 * get = Select
 * post = Insert
 * put = Update
 * delete = Delete (Real shocker there.)
 */

/*
 * Create new endpoints for marathon App.
 * Get races, get runners, add runner, delete runner, update runner.
 */

//Instantiate the slim framework class.
$app = new \Slim\Slim();

//Get races
$app->get('/get_races', 'getRaces');

//Get runners by Race Id
$app->get('/get_runners/:race_Id', 'getRunners');

//Add runner - Json
$app->post('/add_runner/:runner_id', 'addRunner');

//Update runner - Json
$app->put('/update_runner', 'updateRunner');

//Delete runner - Json
$app->delete('/delete_runner/:runner_id', 'deleteRunner');


$app->run();

//
///FUNCTIONS
//
function getRaces()
{
    include("../../template/db_conn.php");

    try
    {
        $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
        //Get all the race data.
        $sql = $db->prepare("SELECT * FROM phpclass.races");
        $sql->execute();
        $rows = $sql->fetchAll();

        //Spit out the result as json.
        $result['races'] = $rows;
        echo json_encode($result);
    }
    catch(PDOException $e)
    {//Create an errors array, and spit it out in Json
        $error = $e->getMessage();

        $errors['error'] = $error;
        echo json_encode($errors);
    }
}

function getRunners($race_id)
{//Used Navicat to generate the SQL statement.

    include("../../template/db_conn.php");

    try
    {
        $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
        //Get runner data by race id.
        $sql = $db->prepare("
                      SELECT member_login.`name`, member_login.email
                      FROM	member_race	
                      INNER JOIN	member_login	
                      ON member_race.member_id = member_login.member_id
                      WHERE	member_race.race_id = :RaceId");
        $sql->bindValue(':RaceId', $race_id);
        $sql->execute();
        $rows = $sql->fetchAll();

        //Spit out the result as json.
        $result['runners'] = $rows;
        echo json_encode($result);
    }
    catch(PDOException $e)
    {//Create an errors array, and spit it out in Json
        $error = $e->getMessage();

        $errors['error'] = $error;
        echo json_encode($errors);
    }

}

function addRunner($runner_id)
{//Only a valid promoter can add a runner to a race.

    //Pulls back the request data, assuming it is Json.
    $request = \Slim\Slim::getInstance()->request();

    //If you want an array use true. False returns it as an object.
    $post_data = json_decode($request->getBody(), true);

    //Dump the Json into variables.
    $member_id = $post_data['member_id'];
    $race_id = $post_data['race_id'];
    $member_key = $post_data['member_key'];

    //echo "$member_id=> $race_id=> $member_key";

    include("../../template/db_conn.php");

    try
    {
        $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
        //Get runner data by race id.
        $sql = $db->prepare("SELECT member_race.race_id, member_login.member_key 
        FROM member_race 
        INNER JOIN member_login ON member_race.member_id = member_login.member_id 
        WHERE member_race.race_id = :RaceId 
        AND member_login.member_key = :ApiKey
        AND member_race.role_id = 2");
        $sql->bindValue('RaceId', $race_id);
        $sql->bindValue('ApiKey', $member_key);
        $sql->execute();
        $row = $sql->fetch();

        if($row == null)
        {
            echo "Bad API Key or Invalid Access.";
        }
        else
        {
            //echo "Good to go with the DB Insert.";

            $sql = $db->prepare("
            INSERT INTO phpclass.member_race(member_id, race_id, role_id)
            VALUES(:Member_Id, :Race_Id, 3)");
            $sql->bindValue("Member_Id", $member_id);
            $sql->bindValue("Race_Id", $race_id);
            $sql->execute();
        }
    }
    catch(PDOException $e)
    {//Create an errors array, and spit it out in Json
        $error = $e->getMessage();

        $errors['error'] = $error;
        echo json_encode($errors);
    }
}

function updateRunner()
{
    //Pulls back the request data, assuming it is Json.
    $request = \Slim\Slim::getInstance()->request();

    $post_data = json_decode($request->getBody(), true);
    //print_r($post_data);

    //Echo just the lName from the Json.
    echo "Updating: ".$post_data["test"];
    print_r($post_data);
}

function deleteRunner($runner_id)
{//Promoter removing a runner from a race. Only a valid promoter can remove a runner.

    $request = \Slim\Slim::getInstance()->request();

    $post_data = json_decode($request->getBody(), true);
    //print_r($post_data);

    //Dump the Json into variables.
    $member_id = $post_data['member_id'];
    $race_id = $post_data['race_id'];
    $member_key = $post_data['member_key'];

    include("../../template/db_conn.php");

    try
    {
        $db = new PDO($db_dsn, $db_username, $db_password, $db_options);
        //Get runner data by race id.
        $sql = $db->prepare("SELECT member_race.race_id, member_login.member_key 
        FROM member_race 
        INNER JOIN member_login ON member_race.member_id = member_login.member_id 
        WHERE member_race.race_id = :RaceId 
        AND member_login.member_key = :ApiKey
        AND member_race.role_id = 2");
        $sql->bindValue('RaceId', $race_id);
        $sql->bindValue('ApiKey', $member_key);
        $sql->execute();
        $row = $sql->fetch();

        if($row == null)
        {
            echo "Bad API Key or Invalid Access.";
        }
        else
        {
            //echo "All set and ready to delete.";

            $sql = $db->prepare("
            DELETE FROM phpclass.member_race WHERE
            member_race.member_id = :Member_Id AND
            member_race.race_id = :Race_Id AND
            member_race.role_id = 3");
            $sql->bindValue("Member_Id", $member_id);
            $sql->bindValue("Race_Id", $race_id);
            $sql->execute();
        }
    }
    catch(PDOException $e)
    {//Create an errors array, and spit it out in Json
        $error = $e->getMessage();

        $errors['error'] = $error;
        echo json_encode($errors);
    }

}
?>