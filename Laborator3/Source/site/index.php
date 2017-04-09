<!DOCTYPE html>
<html lang="en">
    
	<head>
		<meta charset="utf-8" />
		<link rel="shortcut icon" href="images/logo.png" />
		<link rel="stylesheet" href="style.css" type="text/css" />
		<title>Hairstyle portfolio</title>
	</head>

	<body>
            
		<header>
			<div id="logo"><h1>Hairstyle</h1></div>
			<nav>
				<ul>
					<li><a href="index.php?page=home">Acasă</a></li>
					<li><a href="index.php?page=tutorial">Tutoriale</a></li>
					<li><a href="index.php?page=bloggs">Video-bloggeri</a></li>
				</ul>
			</nav>
		</header>
	
		<article>
			<div id="centerer">
				
			
				<section>
					<?php
						if (isset($_GET['page']))
							$page = $_GET['page'];
						else
							$page = 'home';
						if (preg_match('/^[a-z0-9\-]+$/', $page))
						{
							$inserted = include('subpages/' . $page . '.php');
							if (!$inserted)
								echo('Requested page was not found.');
						}
						else
							echo('Invalid parameter.');
					?>
				</section>
				<div class="clearer"></div>
			</div>
		</article>
		
		<footer>
                    <h2>
			diana.sarpe96@gmail.com | Tel: +37369603522
                    </h2>
		</footer>
	</body>
</html>
