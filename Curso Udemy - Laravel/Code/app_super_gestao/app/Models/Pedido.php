<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\BelongsToMany;

class Pedido extends Model
{
    use HasFactory;

    public function produtos(){
        // return $this->BelongsToMany('App\Models\Produto','pedido_produtos');
        return $this->BelongsToMany('App\Models\Item','pedido_produtos','pedido_id', 'produto_id')->withPivot('id','created_at', 'updated_at');
        // 1-Modelo de relaciomaento NxN em relacao o modelo que estamos implementando
        // 2-É a tabela auxiliar que armazena os registros de relacionamento
        // 3-Representa o nome da FK da tabela mapeada pelo modelo na tabela de relacionamento
        // 4-Representa o nome da FK da tabela mepeada pelo model utilizado no relacionamento
    }
}
