<?php
require 'App/Loader.php';

$category = new Category();

$categories = new Categories();

$category->category_id = "2";
$category->category_name = "Pots d'echapement";
$category->category_description = "Si t'en as pas, tu tousses.";

// Edit
$nb_lines = $categories->edit($category);
echo $nb_lines . ' lignes ont été modifiées<br>';

/*
echo '<pre>';
var_export($result);
*/