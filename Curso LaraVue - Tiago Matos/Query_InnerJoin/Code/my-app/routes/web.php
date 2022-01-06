<?php

use App\Http\Controllers\UserController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Route;


// Route::get('/', function (Request $request) {
    // $users = DB::table('users')
    //     ->rightJoin('posts', 'users.id', '=', 'posts.user_id')
    //     ->get();

    // $users = DB::table('users')
    //     ->leftJoin('posts', 'users.id', '=', 'posts.user_id')
    //     ->get();

    // $users = DB::table('users')
    //     ->join('posts', 'users.id', '=', 'posts.user_id')
    //     ->get();

    // $users = DB::table('users')
    //     ->join('posts', function($join){
    //         $join->on('users.id', '=', 'posts.user_id')
    //             ->where('posts.user_id','>',8);
    //     })
    //     ->get();

    // $users = DB::table('users')
    //     ->where('name', 'like', '%' . $request->name . '%')
    //     ->get();
   
    // $name = $request->name;
    //   $users = DB::table('users')
    //     ->when(!empty($name),function($query) use ($name){
    //         $query->where('name', 'like', '%' . $name . '%');
    //     }) 
    //     ->get();

    //   $users = DB::table('users')
    //     ->insert([
    //         'name'=>'Flavio',
    //         'email'=>'flavio.castanho@yahoo.com.br1',
    //         'password' => '124356'
    //     ],
    //     [
    //         'name'=>'Flavio2',
    //         'email'=>'flavio.castanho@yahoo.com.br2',
    //         'password' => '124356'
    //     ]);
        
    //   $users = DB::table('users')
    //     ->insertOrIgnore([
    //         'name'=>'Flavio',
    //         'email'=>'flavio.castanho@yahoo.com.br1',
    //         'password' => '124356'
    //     ],
    //     [
    //         'name'=>'Flavio2',
    //         'email'=>'flavio.castanho@yahoo.com.br2',
    //         'password' => '124356'
    //     ]);

        //pegando o identity da tabela
        
        // $users = DB::table('users')
        // ->insertGetId([
        //     'name'=>'Flavio',
        //     'email'=>'flavio.castanho@yahoo.com.br4',
        //     'password' => '124356'
        // ]);

        // $users = DB::table('users')
        // ->where('id',15)
        // ->update([
        //     'name'=>'Flavio654',
        //     'email'=>'flavio.castanho@yahoo.com.br654',
        //     'password' => '124356'
        // ]);

        //  $users = DB::table('users')
        // ->upsert([
        //     'name' => '654flavio',
        //     'email' => 'email novo'
        // ],
        // ['name','email'],
        // ['name']);

        // $users = DB::table('users')
        // ->updateOrInsert(
        //     [
        //         'name' => 'flavio', 'email' =>'jon@email.com.br2'
        //     ],
        //     [
        //         'remember_token' => 'abc', 'password' => '12435'
        //     ]
        //     );

        //  $users = DB::table('users')
        //     ->where('id',10)
        //     ->increment('contador', 1);
//  $users = DB::table('users')
//             ->where('id',9)
//             ->decrement('contador', 1);

        //  $users = DB::table('users')
        //     ->where('id',9)
        //     ->delete();

        //PAGINAÇÃO
    // $users = DB::table('users')  
    //   ->simplePaginate();
    
    // $users = DB::table('users')  
    //   ->paginate(2);


    // return view('users',[
    //     'users' => $users]);
// });

Route::get('/', [UserController::class,'index']);