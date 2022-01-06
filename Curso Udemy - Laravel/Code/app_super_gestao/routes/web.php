<?php

use App\Http\Controllers\ClienteController;
use App\Http\Controllers\ContatoController;
use App\Http\Controllers\Controller;
use App\Http\Controllers\DiretivaController;
use App\Http\Controllers\FornecedorController;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\LoginController;
use App\Http\Controllers\PedidoController;
use App\Http\Controllers\PedidoProdutoController;
use App\Http\Controllers\PrincipalController;
use App\Http\Controllers\ProdutoController;
use App\Http\Controllers\ProdutoDetalheController;
use App\Http\Controllers\SobrenosController;
use App\Http\Controllers\TesteController;
use App\Http\Middleware\LogAcessoMiddleware;
use App\Models\ProdutoDetalhe;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', [PrincipalController::class,'principal'])
    // ->middleware(LogAcessoMiddleware::class)
    // ou
    //Configurado via Kernel.php nas route
    ->middleware('log.acesso') //Via Apelido
    ->name('site.index');

Route::get('/sobrenos', [SobrenosController::class, 'sobrenos'])->name('site.sobrenos');

Route::get('/contato', [ContatoController::class,'contato'])->name('site.contato');
Route::post('/contato', [ContatoController::class,'salvar'])->name('site.contato');

Route::get('/login/{erro?}', [LoginController::class,'index'])->name('site.login');
Route::post('/login', [LoginController::class,'autenticar'])->name('site.login');

Route::middleware('log.acesso','autenticacao:padrao,visitante')->
    prefix('/app')->
    group(function(){
        // Route::middleware('log.acesso','autenticacao') //Chamada Encadeada
        Route::get('/home', [HomeController::class,'index'])->name('app.home');
        Route::get('/sair', [LoginController::class,'index'])->name('app.sair');
        // Route::get('/cliente', [ClienteController::class,'index'])
        //     ->name('app.cliente');
        
        Route::get('/fornecedor', [FornecedorController::class,'index'])->name('app.fornecedor');
        Route::post('/fornecedor/listar', [FornecedorController::class,'listar'])->name('app.fornecedor.listar');
        Route::get('/fornecedor/listar', [FornecedorController::class,'listar'])->name('app.fornecedor.listar');
        Route::get('/fornecedor/adicionar', [FornecedorController::class,'adicionar'])->name('app.fornecedor.adicionar');
        Route::post('/fornecedor/adicionar', [FornecedorController::class,'adicionar'])->name('app.fornecedor.adicionar');
        Route::get('/fornecedor/editar/{id}/{msg?}', [FornecedorController::class,'editar'])->name('app.fornecedor.editar');
        Route::get('/fornecedor/excluir/{id}', [FornecedorController::class,'excluir'])->name('app.fornecedor.excluir');

        // Route::get('/produto', [ProdutoController::class,'index'])->name('app.produto');
        // Route::get('/produto/create', [ProdutoController::class,'create'])->name('app.produto.create');
        //CRUD
        Route::resource('produto',ProdutoController::class );
        //Produto detalhes
        Route::resource('produto-detalhe',ProdutoDetalheController::class );
        
        Route::resource('cliente',ClienteController::class);
        Route::resource('pedido',PedidoController::class);
        // Route::resource('pedido-produto', PedidoProdutoController::class );
        Route::get('pedido-produto/create/{pedido}', [PedidoProdutoController::class,'create'])->name('pedido-produto.create');
        Route::post('pedido-produto/store/{pedido}', [PedidoProdutoController::class,'store'])->name('pedido-produto.store');
        // Route::delete('pedido-produto/destroy/{pedido}/{produto}', [PedidoProdutoController::class,'destroy'])->name('pedido-produto.destroy');
        Route::delete('pedido-produto/destroy/{pedidoProduto}/{pedido_id}', [PedidoProdutoController::class,'destroy'])->name('pedido-produto.destroy');

        Route::get('/diretiva', [DiretivaController::class,'index'])->name('app.diretiva');
});

Route::get('/teste/{p1}/{p2}', [TesteController::class,'teste'] )->name('site.teste');

// Route::get('/rota2',function(){
//     return redirect()->route('site.rota1');
// })->name('site.rota2');

// Route::redirect('/rota2','/rota1');

Route::fallback(function(){
    return 'A rota acessada não existe. <a href="'.route('site.index').'">Clique aqui</a> para ir para página inicial';
});

// Route::get('/contato/{nome?}/{categoria?}/{assunto?}/{mensagem?}', function(
//         string $nome = 'Desconhecido', 
//         string $categoria = 'Sem Categoria', 
//         string $assunto = 'Sem assunto', 
//         string $mensagem = 'Sem mensagem'
//     ){
//     echo 'Estamos aqui contato: ' . $nome . $categoria . $assunto . $mensagem;
// });

// Route::get('/contato/{nome?}/{categoria_id?}', function(
//         string $nome = 'Desconhecido', 
//         int $categoria_id = 1
//     ){
//     echo "Estamos aqui contato:  $nome '-' $categoria_id";
// })->where('categoria_id','[0-9]+')->where('nome','[A-Za-z]+');