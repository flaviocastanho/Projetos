<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User</title>
</head>
<body>
    <h1>teste</h1>

    @if( 2=== 1)
        Teste 1
    @else 
        Teste2
    @endif

    @unless(2===1)
        teste unless
    @endunless

    @for($i = 0; $i <=10; $i++ )
        {{$i}}
    @endfor

    @if(2==3)
        @foreach($users as $user)
            {{$user->name}}
        @endforeach
    @endif

    @if(2==3)
        @forelse($users as $user)
            {{$user->name}}
        @empty
            nenhum usuario encontrado
        @endforelse
    @endif

    {{--
        <?php $j = 1; ?>

    @while($j <= 10)
        {$j++}
    @endwhile

    @foreach($user as $user)

        {{--Variavel do foreach--}}
        dd($loop)


        @if(1===2)
            continue
        @endif

        @if(1===2)
            break
        @endif 
    @endforeach

    @switch(count($users))
        @case(1)
            Eu tenho 1 usuario
            @break
        @case(5)
            Eu tenho 5 usuarios
            @breadk
        @default
            Eu não tenho usuarios
    @endswitch

    

        --}}

</body>
</html>