<?php
require 'Db.php';
require 'Classes/Category.php';
require 'Classes/Categories.php';
require 'Classes/Product.php';
require 'Classes/Products.php';

function Debuger($var, $exit = null)
{
    echo '<pre>';
    echo var_export($var);

    if($exit !== null)
        exit();
}