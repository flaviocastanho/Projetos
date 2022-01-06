<?php

use Illuminate\Support\Facades\DB;
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
    // $users = DB::table('users')->get();
    // $users = DB::table('users')->find(5);
    // $users = DB::table('users')->first();
    // $users = DB::table('users')->where('email','gaylord.winnifred@example.net')->first();

    // $users = DB::table('users')->where('email','gaylord.winnifred@example.net')->exists();
    // $users = DB::table('users')->where('email','gaylord.winnifred@example.net1')->doesntExist();
    // $users = DB::table('users')->select('name as user_name','email')->get();
    // $users = DB::table('users')->orderByDesc('name')->get();
    
    // $users = DB::table('users')->inRandomOrder('name')->first();
    // $users = DB::table('users')->latest('name')->get();
    // $users = DB::table('users')->oldest('name')->get();
    
    // $users = DB::table('users')->limit(2)->get();
    // $users = DB::table('users')->take(3)->get();

    // $users = DB::table('users')->latest()->limit(3)->get();

    // $users = DB::table('users')->skip(1)->limit(3)->get();
    // $users = DB::table('users')->offset(1)->limit(3)->get();

    // $users = DB::table('users')
    //     ->where('name','=','Louisa Abshire')
    //     ->get();
    // $users = DB::table('users')
    //     ->where('name','like','%dr%')
    //     ->where('id',1)
    //     ->get();

    // $users = DB::table('users')
    //     ->where([
    //         ['name','like','%dr%'],
    //         ['id',1]
    //     ])
    //     ->get();

    // $users = DB::table('users')
    //     ->where([
    //         ['name','Louisa Abshire'],
    //     ])
    //     ->orWhere(function($query){
    //         $query->where('id',1);
    //         $query->orwhere('id',6);
    //     })
    //     ->get();

    // $users = DB::table('users')
    //     ->whereBetween('id',[6,10])
    //     ->get();

    // $users = DB::table('users')
    //     ->whereIn('id',[1,6,10])
    //     ->get();

    // $users = DB::table('users')
    //     ->whereNotNull('id')
    //     ->get();

    // $users = DB::table('users')
    //     ->whereDate('created_at','=','2021-01-01')
    //     ->get();

    // $users = DB::table('users')
    //     ->whereDay('created_at','02')
    //     ->orWhereMonth('created_at','03')
    //     ->orWhereYear('created_at','2021')
    //     ->orWhereTime('created_at','14:02:01')
    //     ->get();

    // $users = DB::table('users')
    //     ->whereColumn('created_at','update_at')
    //     ->get();

    // $users = DB::table('users')    

    dd($users);
  
    return view('welcome', compact('users'));
});

