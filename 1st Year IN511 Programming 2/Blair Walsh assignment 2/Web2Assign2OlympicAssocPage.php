<!DOCTYPE html>

<!--
Web Programming Assignment 1 
Author: blair Walsh
Start Date: 9/09/2013
-->

	<html>
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
		</style>
		<head>
			<title>Web 2 Assignment 2 Olympic Association Blair Walsh</title>
			<meta charset="UTF-8">
		</head>
		
			
			

		<body>
		<div class ="header">
		<img src ="olympicRings.jpg">
		</div>
		
		<div class ="menu">

<ul>
	<li><a href="Web2Assign2OlympicAssocPage.php">Search Athletes</a></li>
	<li><a href="addAthletes.php">Add Athlete</a></li>
	<li><a href="addCountry.php">Add Country</a></li>
	<li><a href="removeAthlete.php">Remove Athlete</a></li><br>
</ul>

</div>
		
		<div class ="container">
		<br>
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

	if (isset($_POST['submitted']))
		{
		//Shows a table of the selected players
			processForm();
		} 
	else
		//hasn’t yet been submitted, display the form
		{
			showForm();
		}	
		
		function showForm()
		{
			$self = htmlentities($_SERVER['PHP_SELF']); 
			;
			
			echo("<form action = '$self' method='POST'>");
			echo("<fieldset>");
			echo("<legend><b>Search</b></legend>");
			
			//name search
			echo("<p><b>Search by first name</b></p>");
			echo("<input type='text' name='firstName'>");
			echo("<p><b>Search by last name</b></p>");
			echo("<input type='text' name='lastName'>");
		  
			//Loads selectString with a string of data from tblOlympic
			//search by sport
			$selectString="SELECT DISTINCT sport FROM tblOlympic";	
			$result = mysql_query($selectString);
			
			echo("<p><b>Search by sport</b></p>");
			echo("<select name='sport'>");
			echo("<option value='%'>All</option>");
			
			//Cycles through each row of data stored in $result
			while($row=mysql_fetch_assoc($result))
				{
					foreach($row as $field)
					{
						echo("<option value='$field'>$field</option>");
					}
				}
					echo("</select>");
					
			//search by gender
			$selectString="SELECT DISTINCT gender FROM tblOlympic";	
			$result = mysql_query($selectString);			
					
			echo("<p><b>Search by gender</b></p>");
			echo("<select name='gender'>");
			echo("<option value='%'>All</option>");
			while($row=mysql_fetch_assoc($result))
			{
				foreach($row as $field)
				{
					echo("<option value='$field'>$field</option>");
				}
			}
					echo("</select>");
			
			//search by country			
			$selectString="SELECT DISTINCT country FROM tblOlympicFlags";	
			$result = mysql_query($selectString);
					
			echo("<p><b>Search by country</b></p>");
			echo("<select name='country'>");
			echo("<option value='%'>All</option>");
			
			while($row=mysql_fetch_assoc($result))
			{
				foreach($row as $field)
				{
					echo("<option value='$field'>$field</option>");
				}
			}
					echo("</select>");

					echo("</fieldset>");
					echo("<br>");
					//submit button
					echo("<input type='submit' name='submitted' value='Search'>");
					
					echo("</form>");
		}
		
		
		
function processForm() //code to process the user input 
			{ 
				$self = htmlentities($_SERVER['PHP_SELF']); 
				$sport = $_POST['sport']; 
				$gender = $_POST['gender'];
				$country = $_POST['country'];
				$firstName = mysql_real_escape_string($_POST['firstName']);
				$lastName = mysql_real_escape_string($_POST['lastName']);
				echo("<form action = '$self' method='POST'>"); 
		//if else statment for name goes here. Use (like '% name goes in here %') first need to check if anything entered into box, if so then links with code below
						
				$selectString = "SELECT * from tblOlympic JOIN tblOlympicFlags ON (tblOlympic.countryCode = tblOlympicFlags.countryCode) 
				WHERE (sport like '$sport') and (gender like '$gender') and (tblOlympicFlags.country like '$country')and (tblOlympic.firstName like '%$firstName%') and (tblOlympic.lastName like '%$lastName%')"; 
				//echo($selectString);
				$result = mysql_query($selectString); 
				echo("<table>"); 
				echo("<tr>
				<th>ID</th>
				<th>Last Name</th>
				<th>First Name</th>
				<th>Height (cm)</th>
				<th>Weight (kg)</th>
				<th>Country Code</th>
				<th>Gender</th>
				<th>Sport</th>
				<th>Events</th>
				<th>Photo</th>
				<th>Country</th>
				<th>Popluation</th>
				<th>Flag</th>
				</tr>");
				while ($row = mysql_fetch_assoc($result))
				{
					echo("<tr>");
					foreach($row as $index => $value)
					if ($index=='image')
					{
					echo ("<td><img src = '$value'></td>");
					}
				
						else if ($index=='flagImage')
						{
						echo ("<td><img src = '$value' alt ='country flag' width ='200' height = '100'></td>");
						}
					
					else
					{
						echo("<td>$value</td>");
					}
					echo("</tr>");
					}
				
				echo("</table>");
			 mysql_free_result($result);
				echo("</form> <form action = '$self' method='POST'> <br> <input type='submit' name='return' value = 'Return to Search'> </form>");
				
		}		
		
					
			?>
			
			</div>
		</body>
	</html>				