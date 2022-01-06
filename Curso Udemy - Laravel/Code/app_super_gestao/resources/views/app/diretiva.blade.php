

    
    <h3>Fornecedor</h3>

    {{--
    Comentarios que sera descartado pelo interpretador do blade
    --}}

    <?= 'Texto de teste' ?>

    @php
        // para comentarios de uma linha

        /*
        comentarios multiplas linhas
        */

        echo 'Texto de teste';

        /*
        if() {

        }else if(){

        }else {
            
        }
        */

    @endphp

    <hr></hr>

    {{-- @dd($fornecedores) --}}
    <h3>IF ELSE</h3>
    @if(count($fornecedores) > 0 && count($fornecedores) < 10)
    <h3>Existem alguns fornecedores cadastrados</h3>
    @elseif(count($fornecedores) > 10 )
    <h3>Existem varios fornecedores cadastrados</h3>
    @else
    <h3>Ainda não existe fornecedores cadastrados</h3>
    @endif

    <hr></hr>

    <h3>UNLESS - INVERSAO DO IF</h3>
    @unless ($fornecedores)
        Verdadeiro
    @else
        Falso    
    @endunless

    <hr></hr>


    <h3>isset - Valida a existencia da variavel</h3>
    @isset($fornecedores)
        verdadeiro
    @else
        false
    @endisset

    <hr></hr>

    <h3>Empty - Valida vazio variavel</h3>
    @empty(!$fornecedores)
        Vazio
    @endempty

    <hr></hr>

    <h3>Operador condicional ternario</h3>
    {{-- @isset($fornecedores[1]['cnpj'] ? 'Verdadeiro' : 'False') --}}

    <hr></hr>

    <h3>Operador default</h3>
        {{$fornecedores[1] ?? 'Valor default'}}
    <hr></hr>

    <h3>Switch/Case</h3>
        @switch($fornecedores[0])
            @case('Fornecedores 2')
                    Teste 1
                @break
        
            @default
                Teste Default
        @endswitch
    <hr></hr>


    <h3>For</h3>
        @for ($i = 0; $i < 10; $i++)
            For: {{$i}}
        @endfor
    <hr></hr>

    <h3>While</h3>
        
        @php $i = 0 @endphp

        @while ($i < 10)
            While: {{$i}}

            @php
                $i++;
            @endphp
        @endwhile

    <hr></hr>

    <h3>Foreach</h3>
    @isset($fornecedores)
        @foreach ($fornecedores as $item)
            {{$item}}
        @endforeach
    @endisset 
    <hr></hr>

    <h3>ForElse</h3>
        @php
            $fornecedores = []
        @endphp

        @forelse ($fornecedores as $item )
            {{$item}}
        @empty
            ForElse vazio
        @endforelse
    <hr></hr>

    <h3>Escapando a tag de impressao do blade</h3>

        @{{$fornecedores}}

    <hr></hr>

    <h3>Loop</h3>
        @php
            $fornecedores = ['Fornecedores 1']    
        @endphp

        @forelse ($fornecedores as $item )
            @if ($loop->last)
                Ultimo
            @endif

            @if ($loop->first)
                Primeiro
            @endif


            Total de itens: {{$loop->count}}
            @dd($loop)
        @empty
            ForElse vazio
        @endforelse

    <hr></hr>
