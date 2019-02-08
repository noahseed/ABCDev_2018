<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Repar'Tout Pneus</title>
    <link rel="stylesheet" href="assets/css/flex.css">
    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet"
    integrity="sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN" crossorigin="anonymous">
</head>

<body>
    <header>
        <img src="assets/img/logo.svg" alt="ReparTout Logo">
    </header>

    <main>
        <nav>
            <h3><a href="#">Menu</a></h3>
            <ul>
                <li><a href="#"><i class="fa fa-tasks"></i> Catégories</a></li>
                <li><a href="#"><i class="fa fa-book"></i> Catalogue</a></li>
                <li><a href="#"><i class="fa fa-users"></i> Clients</a></li>
                <li><a href="#"><i class="fa fa-shopping-basket"></i> Commandes</a></li>
            </ul>
        </nav>

        <section>
            <?php
                require './App/Loader.php';

                $page = (empty($_GET['page']) ? 'categories' : $_GET['page']);

                $path = './App/Views/'.$page.'.php';

                if(is_file($path))
                {
                    require $path;
                }
                else
                {
                    echo '<h2>ERREUR 404</h2><p>La page demandée est introuvable.</p>';
                }
            ?>
        </section>

        <aside>
            <h3>Commandes en cours</h3>
            <ul>
                <li>Aucune commande.</li>
            </ul>
        </aside>
    </main>

    <footer>
        &copy; 2019 Repar'Tout
    </footer>
</body>
</html>