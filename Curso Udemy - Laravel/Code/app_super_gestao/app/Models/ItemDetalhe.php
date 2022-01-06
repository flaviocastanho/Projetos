<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class ItemDetalhe extends Model
{
    use HasFactory;

    protected $table = 'produto_detalhes';
    protected $fillable = ['produto_id', 'comprimento', 'largura', 'altura', 'unidade_id'];

    //Busca dados do relacionamento pai FK
    public function item(){
        return $this->BelongsTo('App\Models\Item','produto_id','id');
    } 
}
