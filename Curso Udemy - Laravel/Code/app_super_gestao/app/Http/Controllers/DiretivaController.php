<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DiretivaController extends Controller
{
    public function index(){
         $fornecedores = ['Fornecedores 1'];
          
        return view('app.diretiva',compact('fornecedores'));
    }
}
