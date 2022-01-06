<?php

use App\Http\Controllers\CheckoutController;
use App\Http\Controllers\PostController;
use App\Http\Controllers\UserController;
use App\Http\Controllers\UserResourceController;
use App\Http\Controllers\UserScopeController;
use App\Models\User;
use Facade\FlareClient\View;
use Illuminate\Http\Request;
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

//Route::prefix('/usertest')->name('admin.')->group(function(){
//    Route::get('/',function(){
//        return 'Hello World';
//    })->name('Users');
//       Route::get('/{id}',function($id){
//        return 'Hello World ' . $id;
//    })->name('user');
//});

//Route::middleware('auth')->group(function(){
//    Route::get('/',function(){
//        return 'Hello World';
//    })->name('Users');
//       Route::get('/{id}',function($id){
//        return 'Hello World ' . $id;
//    })->name('user');
//});

/*usando rota com dominio*/

// Route::domain('{user}.cursolaravelpro.text')->group(function(){
//     Route::get('', function(){
//         return 'Hello World';
//     });
// });

Route::view('/welcome','welcome', ['title'=>'Hello Word']);

Route::get('/', function () {
    return view('welcome');
});

//Route::get('/users2/{id?}/{name}', function($id = null, $name = null){
//    return 'Users' . $id . '-' . $name;
//});

//Route::get('token/{token}',function($token){
//    return $token;
//})->whereNumber('token');

//Route::get('token/{token}',function($token){
//    return $token;
//})->where('token','[0-9]+');

// Route::get('token/{token}',function($token){
//     return $token;
// });

/*Usando empressão regular */
//Route::get('users/{id}',function($id = null){
//    return 'User' . $id;
//})->where('id','[0-9]+');


// /*Usando empressão regular */
// Route::get('users/{id}/{name}',function($id = null, $name = null){
//     return 'User' . $id . $name;
// })->where([
//     'id' => '[0-9]+',
//     'name' => '[A-Za-z]+']);

//Route::redirect('rota-a', 'rota-b', 301);
//Route::permanetRedirect('rota-a','rota-b');

// Route::match(['get', 'post'],'users',function(){
//     return 'hello world';
// })->name('users');

// Route::get('rota-a',function(){
//     //return redirect()->Route('rotab');
//     return Redirect::Route('rotab');
// });

// Route::get('rota-b',function(){
//     return 'rota-b';
// })->name('rotab');

//Route::post('users',function(){});
//Route::delete('users',function(){});
//Route::options('users',function(){});
//Route::patch('users',function(){});


// Route::fallback(function(){
//     return view('Teste Fallback');
// });

// Route::get('/phpinfo',function(){
//     return view('phpinfo');
// });

// Route::get('/migrate/{user}',function(User $user){
//     dd($user);
// });

// Route::get('/',function(Request $request){
//     // dd($request);
//     // dd($request->headers);
//     //dd($request->header('host'));
//     dd($request->query('curso'));
// });

    // Route::get('/post',function(User $user){
    //     dd($user);
    // })->middleware('userAgent');


// Route::middleware(['userAgent', 'checkToken'])->group(function(){
//     Route::get('/',function(User $user){
//         dd($user);
//     });


//     Route::get('/post',function(User $user){
//         dd($user);
//     });

//      Route::get('/services',function(User $user){
//         dd($user);
//     })->withoutMiddleware('userAgent');

// });

/*Controller */
Route::get('/users',[UserController::class,'index']);

Route::get('users/{user}',[UserController::class,'show']);

Route::get('/checkout',CheckoutController::class);

// Route::resource('controller', UserResourceController::class)->only('index');

Route::resources([
    'controller' => UserController::class,
    'posts' => UserController::class
]);

/*remove os metodos create...  */
Route::apiResource('teste1',UserController::class)->names([
    'create'=> 'usuario.criar',
    'update'=> 'usuario.atualizar'
]);

/*Remove primeiro parametro  */
Route::Resource('teste3.comments',UserController::class)->shallow();

Route::resource('/posts',PostController::class)->parameters([
    'posts' => 'admin_post'
]);


// Route::get('scope/{user:email}',[UserScopeController::class,'show']);

Route::resourceVerbs([
    'create' => 'criar',
    'edit' => 'editar'
]);

Route::resource('scope',UserScopeController::class)->scoped([
    'user' =>'email'
]);

// Route::get('request', function(Request $request){
//     // dd($request);
//     // dd($request->path());
//     // dd($request->url());
//     //  dd($request->fullUrl());
//     // dd($request->fullUrlWithQuery(['curso'=>'laravel']));
//     //  dd($request->fullUrlIs('http://127.0.0.1:8000/request?teste=c'));
//     //  dd($request->is('request'));
//     //  dd($request->is('request/*'));
//     //  dd($request->routeIs('request'));
//     // dd($request->method() === 'GET');
//     dd($request->isMethod('get'));
// })->name('request');

// Route::get('request/{user}', function(Request $request){
//     // dd($request->input('token','input'));
//     // dd($request->input('product.name')); return //http://127.0.0.1:8000/request/1?token=c&product[name]=teste
//     //  dd($request->input());
//     //  dd($request->query());
//     //  dd($request->query('token'));
//     //  dd($request->query('token','retorna default'));
//     // dd($request->token); //metodo direto
//     // dd($request->only('token')); //apenas o parametro
//     // dd($request->except('token')); //exceção do parametro
//     // dd($request->query('token'));
//     // dd($request->has('token'));
//     // dd($request->has(['token','curso'])); //http://127.0.0.1:8000/request/1?token=c&curso=laravel&product[name]=teste
//     // dd($request->whenHas('token',function($input){
//     //         dd('Faca alguma coisa','$input');
//     // }));
//     // if ($request->hasAny(['token','curso'])){
//     //     dd('faca alguma coisa - IF');
//     // };
//     // if ($request->filled('token')){
//     //     dd('faca alguma coisa - filled'); //valida vazio
//     // };
//     // $request->whenFilled('curso',function($input){
//     //     dd('funcao whenFilled'); //http://127.0.0.1:8000/request/1?token=c&curso=laravel&product[name]=teste
//     // });
//       if ($request->missing('token')){
//         dd('funcao missing'); //quando nao existe o parametro
//     };
// })->name('request');

// Route::get('/testeview', function(){
//     return view('user.profile');
// });

// Route::get('/profile', function(){    
//     return View::first(['user.profile','prifile_new']);
// });

// Route::get('/user2', [UserController::class,'index']);


Route::get('/blade', function(){    
    return view('user.profile');
});