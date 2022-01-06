<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Item extends Model
{
    use HasFactory;

    //Altera o nome da tabela 
    protected $table = 'produtos';
    protected $fillable = ['nome', 'descricao', 'peso', 'unidade_id','fornecedor_id'];

    public function itemDetalhe(){
        //Faz um relacionamento produtodetalhe com Produto automatico FK
        return $this->hasOne('App\Models\ItemDetalhe','produto_id','id');
    } 

    public function fornecedor(){
        
        return $this->belongsTo('App\Models\Fornecedor','fornecedor_id','id');
    } 

    public function pedidos(){
        
        return $this->belongsToMany('App\Models\Pedido','pedido_produtos','produto_id', 'pedido_id');
    } 
}
