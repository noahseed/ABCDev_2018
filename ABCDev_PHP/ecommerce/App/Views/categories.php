<?php
    $categories = new Categories();

    if (!empty($_GET['delete'])) {
        $id = intval($_GET['delete']);

        $cat2delete = $categories->find($id);

        if (!empty($cat2delete)) {
            if (!empty($_GET['confirm'])) {
                $categories->delete($id);
            }
            else {
                echo '<p>Souhaitez-vous supprimer la catégorie
                '.htmlspecialchars($cat2delete['category_name']).' ?
               Cette action est irreversible<br>
               <a href="index.php?page=categories&delete='.$id.'&confirm=1">Oui, supprimer cette catégorie</a></p>';
            }
        }
    } elseif (!empty($_GET['edit'])) {
        $id = intval($_GET['edit']);

        $cat2edit = $categories->find($id);

        if (!empty($cat2edit)) {
            if (!empty($_POST['confirm'])) {
                $categories->edit($id);
            }
            else {
?>
<form action="Forms/form_categories_edit.php" method="POST" enctype="multipart/form-data">
    <input type="text" value="<?php echo $cat2edit['category_name']; ?>" name="category_name">
    <textarea name="category_description"><?php echo $cat2edit['category_description']; ?></textarea>
    <input type="hidden" name="confirm" value="1">
    <input type="submit" value="Modifier">
</form>
<?php
            }
        }
    } else {

    $result = $categories->findAll();
?>
<h2>Catégories</h2>
<p>Gérer les catégories</p>

<form action="Forms/form_categories_add.php" method="POST" enctype="multipart/form-data">
    <table border="1">
        <tr>
            <th>ID</th>
            <th>Nom</th>
            <th>Description</th>
            <th>Actions</th>
        </tr>
        <tr>
            <td class="center">#</td>
            <td class="center"><input type="text" value="" name="category_name"></td>
            <td class="center"><input type="text" value="" name="category_description"></td>
            <td class="center"><input type="submit" value="Ajouter"></td>
        </tr>
<?php
        foreach($result as $category)
        {
            echo '<tr>';
            echo '<td class="center">'.$category['category_id'].'</td>';
            echo '<td>'.htmlspecialchars($category['category_name']).'</td>';
            echo '<td>'.htmlspecialchars($category['category_description']).'</td>';
            echo '<td class="center">
                <a href="index.php?page=categories&edit='.$category['category_id'].'">
                    <i class="fa fa-edit fa-2x"></i>
                </a>
                <a href="index.php?page=categories&delete='.$category['category_id'].'">
                    <i class="fa fa-remove fa-2x"></i>
                </a>
                </td>';
            echo '</tr>';
        }
?>
    </table>
</form>
<?php
    }
?>