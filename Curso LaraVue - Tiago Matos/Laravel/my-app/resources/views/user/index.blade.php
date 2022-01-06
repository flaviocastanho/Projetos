@extends('layout.default');

@section('content')

    <x-form.button
        name="Salvar"
        variant="success"
    >
    </x-form.button>


    <x-user.user-list
        type="list"
        teste="teste2"
    >

    </x-user.user-list>

    <x-user.user-list
        type="card"
    >

    </x-user.user-list>
 



    {{--Incluindo subviews--}}
    @include('user.heading')

    {{--quando nao existe a view --}}
    @includeIf('user.heading2')

    @includeWhen(true,'user.heading')

    @includeUnless(true,'user.heading')

    @includeFirst(['user.heading','user.heading2'])

    @include('heading2',[
        'title' => 'Usuarios'
    ])

    {{--
         <?php echo $user; ?>
     <?php echo $userAdmin; ?> 
   --}}

    @php
        $count = 5;

        echo $count;

  
    @endphp


    {{$count}}

@endsection

@section('yield')

        Conteudo do yield
@endsection

@push('css')
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">
@endpush

