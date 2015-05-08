<!DOCTYPE html>

<!--
Web Programming Assignment 1 
Author: blair Walsh
Start Date: 9/09/2013
-->

	<html>
	<head>
	<style>
		body
		{
			margin-left:100px;
		}
		
		
		table
		{
			width:100%; 
			border-collapse: collapse;
			padding:1px;
			margin:10px;
			width:80%;
			margin: 0 auto;
		}
						
		td, th
		{
			border:2px solid red;
			padding: 10px;							
		}
		
		.container img
		{
			width:180px;
			height:200px;
		}
		#headerImg
		{
			margin-left:20%;
		}
		</style>
		
			<title>Web 2 Assignment 1 Blair Walsh</title>
			<meta charset="UTF-8">
			
		</head>
		
		
			
		
		<body>
		<div id ="headerImg">
		<img src ="olympicRings.jpg" alt = "rings">
		</div>
		<div class ="container">
			<?php
				$host = "localhost";
				$userMS = "walshbj2";
				$passwordMS = "12002217";
				
				//Establishing connection to MySQL
				$connection = mysql_connect($host, $userMS, $passwordMS) or die("Couldn't connect:". mysql_error());
				
				$database = "walshbj2_IN612";