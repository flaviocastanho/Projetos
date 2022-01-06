<?php

use App\Exceptions\InvalidOrderException;
use App\Http\Controllers\AuthController;
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

Route::get('/', function () {
     //abort_if(true,401,'Pagina de teste');
     throw new InvalidOrderException();
    return view('welcome');
});

 Route::get('login',[AuthController::class,'login'])->name('login.index');
 Route::post('login',[AuthController::class,'store'])->name('login.store');

 Route::get('login2',function(){
     dd('login2');
 });