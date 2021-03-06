<?php


abstract class Db
{
    protected static $_instance = null;

    public static function getInstance()
    {
        if(self::$_instance === null)
        {
            self::$_instance = new PDO
            (
                'mysql:host=localhost;dbname=ecommerce;port=3306;charset=utf8',
                'ecommerce',
                'Cdi1234',
                [
                    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
                    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC
                ]
            );
        }

        return self::$_instance;

    }

    protected $pdo;

    public function __construct()
    {
        $this->pdo = Db::getInstance();
    }

    abstract public function find(int $id);

    abstract public function findAll();

}
