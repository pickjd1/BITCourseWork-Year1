<!DOCTYPE html>

<!--
Web Programming Assignment 1 
Author: blair Walsh
Start Date: 6/09/2013
-->

	<html>
		<head>
			<title>Web 2 Assignment 1 Blair Walsh</title>
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
			margin-left:17%;
		}
		</style>
			
			</head>
			<header>
			</header>
		<body>
		<div class ="header">
		<img src ="olympicRings.jpg">
		</div>
		
		<div class ="container">
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

				$dropQuery = "DROP TABLE IF EXISTS tblOlympic;";
				$result = mysql_query($dropQuery);

				$createQuery ="CREATE TABLE tblOlympic
				(
					ID INT(6)	NOT NULL AUTO_INCREMENT,
					lastName VARCHAR(20)	NOT NULL,
					firstName VARCHAR(20)	NOT NULL,
					height INT(3)	NOT NULL,
					weight INT(3)	NOT NULL,
					countryCode VARCHAR(3)	NOT NULL,
					gender VARCHAR(1)	NOT NULL,
					sport VARCHAR(20)	NOT NULL,
					events VARCHAR(60)	NOT NULL,
					image VARCHAR(20)	NOT NULL,
					
					Primary Key(ID)
				)";
				
				$result = mysql_query($createQuery);
				echo("Result of creating table is $result <br>");
				
				$dropQuery = "DROP TABLE IF EXISTS tblOlympicFlags;";
				$result = mysql_query($dropQuery);
				$createQuery ="CREATE TABLE tblOlympicFlags
				(
					countryCode VARCHAR(3)	NOT NULL,
					country VARCHAR(30)	NOT NULL,
					population VARCHAR(20)	NOT NULL,
					flagImage VARCHAR(20)	NOT NULL,
					
					Primary Key(countryCode)
				)";
				
						
				$result = mysql_query($createQuery);
				echo("Result of creating table is $result <br>");
				
				function createRecord ($lastName, $firstName, $height, $weight, $countryCode, $gender, $sport, $events, $image)
				{
				$insertQuery = "INSERT INTO tblOlympic (lastName, firstName, height, weight, countryCode, gender, sport, events, image) values ('$lastName','$firstName','$height','$weight','$countryCode','$gender','$sport','$events','$image')";
				$result = mysql_query($insertQuery);
				$count = mysql_insert_id(); 
				//echo("creating record $count");
				}
				
				createRecord('Flynn','Gemma','168','60','NZL','F','Hockey','Womens Hockey','Flynn.jpg');
				createRecord('Eastham','Casey','170','62','AUS','F','Hockey','Womans Hockey','Eastham.jpg');
				createRecord('Liukin','Nastia','160','52','USA','F','Gymnastics','Womens Team','Liukin.jpg');
				createRecord('Klishina','Darya','172','54','RUS','F','Athletics','Womens Long Jump','Klishina.jpg');
				createRecord('Rice','Stephanie','176','67','AUS','F','Swimming','Womens 400m Individual Medley, Womens 200m Individual Medley','Rice.JPG');
				createRecord('Evans','Blair','175','65','AUS','F','Swimming','Womens 400m Individual Medley','Evans.JPG');
				createRecord('Ivanovic','Ana','184','69','SRB','F','Tennis','Womens Singles','Ivanovic.jpg');
				createRecord('Hersey','Kathleen','180','75','USA','F','Swimming','Womens 4 x 200m Freestyle Relay','Hershey.jpg');
				createRecord('Solo','Hope','175','65','USA','F','Soccer','Womens Soccer','Solo.jpg');
				createRecord('Sesselmann','Lauren','173','66','CAN','F','Soccer','Womens Soccer','Seselmann.jpg');
				createRecord('Coburn','Emma','173','54','USA','F','Athletics','Womens 3000m steeplechase','Coburn.jpg');
				createRecord('Carvalho','Jaqueline','186','70','BRA','F','Volleyball','womens Volleyball','Carvalho.jpg');
				createRecord('Franco','Leryn','172','57','PAR','F','Athletics','Womens Javlin','Franco.jpg');
				createRecord('Menegatti','Marta','180','95','ITA','F','Volleyball','Womens Volleyball','Menegatti.jpg');
				createRecord('Jones','Luuka','172','63','NZL','F','Canoe/Kayak','K-1 - Women','Jones.jpg');
				
				function createCountryRecord ($countryCode, $country, $population, $flagImage)
				{
				$insertQuery = "INSERT INTO tblOlympicFlags (countryCode, country, population, flagImage) values ('$countryCode','$country','$population','$flagImage')";
				$result = mysql_query($insertQuery);
				$count = mysql_insert_id(); 
				//echo("creating record $count");
				}
		
				createCountryRecord('NZL','New Zealand','4 500 000','new-zealand.gif');
				createCountryRecord('AUS','Australia','23 100 000','australia.gif');
				createCountryRecord('USA','United States of America','316 600 000','united-states.gif');
				createCountryRecord('RUS','Russia','143 400 000 ','russia.gif');
				createCountryRecord('SRB','Serbia','7 200 000','serbia.gif');
				createCountryRecord('CAN','Canada','35 100 000','canada.gif');
				createCountryRecord('BRA','Brazil','201 000 000','brazil.gif');
				createCountryRecord('PAR','Paraguay','6 600 000','paraguay.gif');
				createCountryRecord('ITA','Italy','59 700 000','italy.gif');
				
				mysql_free_result($result);				
				
			?>
			</div>
		</body>
	</html>