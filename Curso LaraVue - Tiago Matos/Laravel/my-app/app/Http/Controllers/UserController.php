<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Http\Request;

class UserController extends Controller
{
    public function index()
    {
        // return view('user.index',[
        //     'user'=> 'Nome Usuario'
        // ]);

        // return view('user.index')->with([
        //     'user' => 'Nome de usuario 2'
        // ]);
        // $view = view('user.index');

        // $view->with(['user' => 'Nome usuario 3']);

        // $view->with(['user2' => 'Nome user2']);

        // return $view;

        $users = User::all();

        // dd($users);

        return view('user.index');

    }
}
