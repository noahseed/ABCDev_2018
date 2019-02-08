<?php

class Products extends Db
{
    public function find(int $id)
    {
        $sql = "SELECT
        prod_id,
        prod_name,
        prod_buy_price,
        prod_sell_price,
        prod_description
        FROM products
        WHERE prod_id=:tata";

        $stmt = $this->pdo->prepare($sql);

        $stmt->bindValue(
            ':tata',
            $id,
            PDO::PARAM_INT
        );

        if($stmt->execute())
        {
            $result = $stmt->fetch();
        }

        $stmt->closeCursor();

        return $result;
    }

    public function findAll()
    {
        $sql = "SELECT
        prod_id,
        prod_name,
        prod_buy_price,
        prod_sell_price,
        prod_description
        FROM products";

        $stmt = $this->pdo->prepare($sql);

        if($stmt->execute())
        {
            $result = $stmt->fetchAll();
        }

        $stmt->closeCursor();

        return $result;
    }
}
