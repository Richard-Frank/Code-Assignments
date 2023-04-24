<?php
phpinfo();

//Misc notes

//  MASTER PASS: (The one with the padlock): Usual Password
//  DATABASE PASS: dbdev123
// Your IP address may change if you restart the host VM. Use | Views > Tool Windows > Remote Host | to check.

//Debug Tools
//Prints a var with complete information. Datatype etc.
/*
$var = "Hello";
var_dump($var);
$floatvar = 12.6;
var_dump($floatvar);
*/
/*
$array = [];
$array[0] = "Bob";
$array{1} = "Steve";
$array[] = "Greg";
var_dump($array);
*/
/*
$names = ["Bob", "Steve", "Greg"];
var_dump($names[1]);
*/
/*
//Associative Array, a keyed array similar to a two column table.
//Keys, Bob | Steve | Greg
$names = [
    'Bob' => 'Bob@Email.com',
    'Steve' => 'Steve@Email.com',
    'Greg' => 'Greg@Email.com'
];
//Gets Greg's email by using Greg as the key
var_dump($names["Greg"]);


//
///From index.php in API
//

//Build a GET route. Takes URL and function.
$app->get('/getHello', 'getHello');


//Build Show Member Endpoint, takes a member name as a parameter.
$app->get('/showMember/:memberName', 'showMember');

//Build Add Member Endpoint.
$app->post('/addMember/:memberName', 'addMember');

$app->post('/addJson', 'addJson');

$app->delete('/delUser/:userId', 'delUser');


function getHello()
{// http://10.6.112.243/API/v1/index.php/getHello //URL rewritten in .htaccess to http://10.6.112.243/API/v1/getHello
    echo "Hello World.";
}
function showMember($memberName)
{
    echo "Hello $memberName";
}
function addMember($memberName)
{
    echo "$memberName has been added.";
}
function addJson()
{//Some quick Json for Advance REST service.
//{"fName":"Bob","lName":"Smith","adress":"123FakeSt","City":"Oshkosh","State":"WI","ZIP":"12345"}

    //Pulls back the request data, assuming it is Json.
    $request = \Slim\Slim::getInstance()->request();

    $post_data = json_decode($request->getBody(), true);
    //print_r($post_data);

    //Echo just the lName from the Json.
    echo $post_data["lName"];
}
function delUser($userId)
{
    echo "Deleting $userId";
}
*/