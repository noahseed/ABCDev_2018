<?php

class Categories extends Db
{
    public function find(int $id)
    {
        $sql = "SELECT
        `category_id`,
        `category_name`,
        `category_description`
        FROM `categories`
        WHERE `category_id` = :toto";

        $stmt = $this->pdo->prepare($sql);

        $stmt->bindValue(
            ':toto',
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
        `category_id`,
        `category_name`,
        `category_description`
        FROM `categories`";

        $stmt = $this->pdo->prepare($sql);

        if($stmt->execute())
        {
            $result = $stmt->fetchAll();
        }

        $stmt->closeCursor();

        return $result;
    }

    public function add(Category $category) : int
    {
        $sql = "INSERT INTO
        `categories`
        (
            `category_name`,
            `category_description`
        )
        VALUES
        (:name, :descr)";

        $stmt = $this->pdo->prepare($sql);

        $stmt->bindValue(':name', strip_tags($category->category_name));
        $stmt->bindValue(':descr', strip_tags($category->category_description));

        $result = 0;

        if($stmt->execute())
        {
            $result = $stmt->rowCount();
        }

        $stmt->closeCursor();

        return $result;
    }

    public function edit(Category $category)
    {
        $sql = "UPDATE
        `categories`
        SET
        `category_name` = :name,
        `category_description` = :descr
        WHERE
        `category_id` = :id";

        $stmt = $this->pdo->prepare($sql);

        $stmt->bindValue(':id', $category->category_id, PDO::PARAM_INT);

        $stmt->bindValue(':name', strip_tags($category->category_name));

        $stmt->bindValue(':descr', strip_tags($category->category_description));

        $stmt->execute();

        $stmt->closeCursor();
    }

    public function delete(int $id)
    {
        $sql = "DELETE
        FROM
        `categories`
        WHERE
        `category_id` = :id";

        $stmt = $this->pdo->prepare($sql);

        $stmt->bindValue(':id', $id, PDO::PARAM_INT);

        $result = 0;

        if($stmt->execute())
        {
            $result = $stmt->rowCount();
        }

        $stmt->closeCursor();

        return $result;
    }
}
