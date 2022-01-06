Site da Aplicação

{{-- Verifica se o usuario esta autenticado --}}
@auth
    <h1>Usuario autenticado</h1>
    <p>ID {{Auth::user()->id}}</p>
    <p>Nome {{Auth::user()->name}}</p>
    <p>Email {{Auth::user()->email}}</p>
@endauth

{{-- Verifica oposto do auth que não esta autenticado --}}
@guest
   <p>Ola visitante</p> 
@endguest