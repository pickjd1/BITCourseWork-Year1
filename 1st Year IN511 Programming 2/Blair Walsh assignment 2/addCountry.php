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
			height: 30px;
			width: 1200px;
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
	<li><a href="removeAthlete.php">Remove Athlete</a></li><br><br>
</ul>
</div>
		
	<div class ="container">
					
	<h2>Add Country</h2>

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

function addCountry()
{
		mysql_select_db("tblOlympicFlags");

		$insertQuery = "INSERT INTO tblOlympicFlags (countryCode, country, population, flagImage) VALUES 
		('$_POST[addCountryCode]','$_POST[addCountry]','$_POST[addPopulation]','noCountryFlag.jpg')";
echo("$insertQuery");
		$result = mysql_query($insertQuery);
		
		echo("<h3>Country Added!</h3>");

}

function countryDetails()
{
$self=htmlentities($_SERVER['PHP_SELF']);
	echo("

		<form action='$self' method='POST'>
		<fieldset>
		<legend><b>Country Details</b></legend>
		Country Code: <input type='text' name='addCountryCode'><br>
		Country Name: <input type='text' name='addCountry'><br>
		Population: <input type='text' name='addPopulation'><br>
		
		
	</fieldset><br>
	<input type='submit' name='addCountry' value='Add Country'>
	</form>
	");
}

if(isset($_POST['addCountry']))
{
	addCountry();
}

else
{
	countryDetails();
}

?>

</div>
</div>

</body>
</html>