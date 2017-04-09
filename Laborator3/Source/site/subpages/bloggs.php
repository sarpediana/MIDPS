<?php

require_once('Db.php');
    Db::connect('127.0.0.1', 'bloggers', 'root', '');
    if ($_POST)
                {
        Db::query('
                                INSERT INTO blog (bloggername, link)
                                VALUES (?, ?)
                        ', $_POST['bloggername'], $_POST['link']);

                }
?>
<form method="post" class="centered">
    <h2>Introdu aici un link cu adresa unui Vlogger preferat:</h2><br /><h3>
        Denumirea Vlogger-ului:
    <input type="text" name="bloggername" /><br />
        Link-ul Site-ului  :   
    <input type="text" name="link" /><br />
</h3>
    <br /><input type="submit" value="Adaugă" />
</form>
<?php
$users = Db::queryAll('
        SELECT *
        FROM blog
');
echo('<h2>blog</h2><table border="1">');
foreach ($users as $blog)
{
    
        echo('<tr><td>' . htmlspecialchars($blog['bloggername']));
        echo('</td><td>' . htmlspecialchars($blog['link']));
        echo('</td></tr>');
}
echo('</table>');
?>