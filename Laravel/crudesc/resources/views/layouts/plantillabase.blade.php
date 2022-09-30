<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>CRUD</title>
    <style type="text/css"> 
   nav{
    background: #44A4CE;
    width: 100%;
    height: 50px;
    clear: both;
    content: '';
    display: table;
    float: right;
   }
   nav ul li{
    list-style: none;
    margin-left: 20px;
    padding: 12px;
    float: left;
    position: relative;
   }
   nav ul li a{
    text-decoration: none;
    color: #FFFFFF;
    font-weight: bold;
    margin-left: 130px;
   }
    </style>
  </head>
  <body>
  <nav class="menu">
  <ul>
    <li><a href="http://127.0.0.1:8000/alumnos">Alumnos</a></li>
    <li><a href="http://127.0.0.1:8000/materias">Materias</a></li>
    <li><a href="http://127.0.0.1:8000/calificaciones">Calificaciones</a></li>
  </ul>
</nav>

    <h1 class="bg-primary text-while text-center">CRUD Escuela</h1>

    <div class="container">
        @yield('contenido')
</div>    

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

  </body>
</html>