<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    @stack('css')

    <title>Laravel App</title>
</head>
<body>
    @section('content')
        Conteudo padrão
    @show

    <br>
    <br>

    @yield('yield','Conteudo padrao do yield')
</body>
</html>