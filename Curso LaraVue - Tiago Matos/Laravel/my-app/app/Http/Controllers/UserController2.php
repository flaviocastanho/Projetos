<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    public function __construct()
    {
        // $this->middleware('checkToken')->only('index');
         $this->middleware('checkToken')->except('index');
    }

    public function index()
    {

        return dd('x');

    }

    public function show(Request $request,User $user)
    {
        // dd('show' , $id, $request->method());
        // dd($user);
        return $user;
    }
}
