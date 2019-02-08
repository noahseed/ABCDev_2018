<?php

require_once '../App/Loader.php';

if (!empty($_POST['category_name']) &&
	isset($_POST['category_description']))
{
	$category = new Category();
	$category->category_name = $_POST['category_name'];
	$category->category_description = $_POST['category_description'];

	$categories = new Categories();
	$categories->add($category);

	if(!headers_sent())
	{
		header('location: ../index.php?page=categories');
		exit();
	}
}
if(!headers_sent())
{
	header('location: ../index.php?page=categories');
	exit();
}
