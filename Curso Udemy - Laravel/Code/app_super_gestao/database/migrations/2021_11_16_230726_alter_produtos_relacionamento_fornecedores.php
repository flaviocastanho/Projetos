<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;
use Illuminate\Support\Facades\DB;

class AlterProdutosRelacionamentoFornecedores extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        //criando a coluna em produtos que vai receber a fk de fornecedores

        Schema::table('produtos',function(Blueprint $table){
            //Insere um registro de fornecedo para estabelecer o relaciomento
            $fornecedor_id = DB::table('fornecedores')->insertGetId([
                'nome' => 'Fornecedor Padrão SG',
                'site' => 'fornecedor.com.br',
                'uf' => 'SP',
                'email' => 'contato@contato.com.br',
            ]);

            $table->unsignedBigInteger('fornecedor_id')->default($fornecedor_id)->after('id');
            $table->foreign('fornecedor_id')->references('id')->on('fornecedores');
        });

        
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
         Schema::table('produtos',function(Blueprint $table){
            $table->dropForeign('produtos_fornecedor_id_foreing');
            $table->dropColumn('fornecedor_id');
        });
    }
}
