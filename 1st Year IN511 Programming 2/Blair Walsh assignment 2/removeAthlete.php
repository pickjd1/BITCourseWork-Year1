<!DOCTYPE html>

<!--
Web Programming Assignment 1 
Author: blair Walsh
Start Date: 14/09/2013
-->

	<html>
		<head>
			<title>Web 2 Assignment 2 Olympic Association Blair Walsh</title>
			<meta charset="UTF-8">
		</head>
		<style>
		body
		{
			margin-left:100px;
		}
		table
		{
			border-collapse: collapse;
			padding:1px;
			margin:10px;
		}
						
		td, th
		{
			border:2px solid red;
			padding: 10px;							
		}
		.container img
		{
			width:150px;
			height:200px;
		}
		
		.flagcontainer img
		{
			width:300px;
			height:200px;
		}

		.header img
		{
			margin-left:20%;
		}
		
		.menu {
			height: 35px;
			width: 800px;
			margin: auto;
			font-size: 26px;
			text-align: center;
		}
		
		.menu a {
			float: left;
			display: block;
			height: auto;
			width: auto;
			text-decoration: none;
			font-family: Impact, Charcoal;
			color: black;
			margin-left: 60px;
		}

		.menu li a:hover {
			color: red;
		}

		.menu a:visited {
			color: blue;
		}

		.menu a:active {
			color: green;
		}

		.menu ul {
			list-style-type: none;
			margin: 0px;
			padding: 0px;
		}
		
		.container2 {
			background: #FF8080;
			height: auto;
			width: auto;
			padding:20px;
			border: solid black 1px;
		}
		</style>
		
			</head>
			<header>
			</header>
		<body>
		<div class ="header">
		<img src ="olympicRings.jpg">
		</div>
		
		<div class ="menu">

<ul>
	<li><a href="Web2Assign2OlympicAssocPage.php">Search Athletes</a></li>
	<li><a href="addAthletes.php">Add Athlete</a></li>
	<li><a href="addCountry.php">Add Country</a></li>
	<li><a href="removeAthlete.php">Remove Athlete</a></li>
</ul>

</div>
		
		<div class ="container">
			
			
			<h2>Remove Athlete</h2>

<div class="container2">
<?php

$host = "localhost";
				$userMS = "walshbj2";
				$passwordMS = "12002217";
				
				$connection = mysql_connect($host, $userMS, $passwordMS) or die("Couldn't connect:". mysql_error());
				
				$database = "walshbj2_IN612";
				/*
				//This is the code used to create the database initially - only needs to be run the first time.
				
					$createDbQuery ="CREATE DATABASE $database";
					$result = mysql_query($createDbQuery);
				
					echo("Result of creating database is $result");
				*/
				$db = mysql_select_db($database, $connection) or die("Couldn't select database");
				

function removeAthlete()
{
	$removedAthlete = $_POST['removedAthlete'];

	$removeString = "DELETE FROM tblOlympic WHERE ID = '$removedAthlete'";
	$result = mysql_query($removeString);

	echo("<h3>Athlete removed!</h3>");

	echo("<img src='images/athleteRemoved.jpg' alt='athleteRemoved' class='endImage'>");

	echo "<meta http-equiv='refresh' content='3;url=removeAthlete.php'/>";
}

function selectAthlete()
{
	

	$selectString = "SELECT ID, lastName, firstName, height, weight, countryCode, gender, sport, events FROM tblOlympic";
	$result = mysql_query($selectString);

	echo("<form action='' method='POST'>");
		echo("<fieldset>");
			echo("<legend>Athlete Select</legend>");
			echo("Select athlete to remove: ");

			echo("<select name='removedathlete'>");
			
			while($rows = mysql_fetch_assoc($result))
			{
				$ID = $rows['ID'];
				$lastName = $rows['lastName'];
				$firstName = $rows['firstName'];
				$height = $rows['height'];
				$weight = $rows['weight'];
				$countryCode = $rows['countryCode'];
				$gender = $rows['gender'];
				$sport = $rows['sport'];
				$events = $rows['events'];
				
				echo("<option value= '$ID'>$lastName $firstName $height $weight $countryCode $gender $sport $events</option>");
			}

			echo("</select>");
			echo("<br>");

		echo("</fieldset>");
		echo("<br>");
		echo("<input type='submit' name='removeAthlete' value='Remove Athlete'>");
	echo("</form>");
}

if(isset($_POST['removeAthlete']))
{
	removeAthlete();
}

else
{
	selectAthlete();
}



?>

</div>
</div>

</body>
</html>