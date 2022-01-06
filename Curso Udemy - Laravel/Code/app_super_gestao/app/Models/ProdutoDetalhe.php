<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\BelongsTo;

class ProdutoDetalhe extends Model
{
    use HasFactory;

    protected $fillable = ['produto_id', 'comprimento', 'largura', 'altura', 'unidade_id'];

    //Busca dados do relacionamento pai FK
    public function produto(){
        return $this->BelongsTo('App\Models\Produto');
    }
}
