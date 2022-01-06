
@if (isset($produto->id))
    <form method="post" action="{{route('produto.update', ['produto'=>$produto->id])}}">
        @csrf
        @method('PUT')
@else
    <form method="post" action="{{route('produto.store')}}">
        @csrf
@endif   

    <select name="fornecedor_id">
        <option>--Selecione um Fornecedor</option>
        @foreach ($fornecedores as $fonecedor)
            <option value="{{ $fonecedor->id }}" {{ ( $produto->fornecedor_id ?? old('fornecedor_id') ) == $fonecedor->id ? 'selected' : '' }} >{{ $fonecedor->nome }}</option>
        @endforeach                      
    </select>  
    {{$errors->has('fornecedor_id') ? $errors->first('fornecedor_id') : ''}}

    <input type="hidden" name="id" value="">
    
    <input type="text" name="nome" value="{{$produto->nome ?? old('nome')}}" placeholder="Nome" class="borda-preta">
    {{$errors->has('nome') ? $errors->first('nome') : ''}}
    
    <input type="text" name="descricao" value="{{$produto->descricao ?? old('descricao')}}" placeholder="Descrição" class="borda-preta">
    {{$errors->has('descricao') ? $errors->first('descricao') : ''}}
    
    <input type="text" name="peso" value="{{$produto->peso ?? old('peso')}}" placeholder="Peso" class="borda-preta">
    {{$errors->has('peso') ? $errors->first('peso') : ''}}
    
    <select name="unidade_id">
        <option>--Selecione a Unidade de Medida</option>
        @foreach ($unidades as $unidade)
            <option value="{{ $unidade->id }}" {{ ( $produto->unidade_id ?? old('unidade_id') ) == $unidade->id ? 'selected' : '' }} >{{ $unidade->descricao }}</option>
        @endforeach                      
    </select>      
    {{$errors->has('unidade_id') ? $errors->first('unidade_id') : ''}}
    <button type="submit" class="borda-preta">Cadastrar</button>
</form>