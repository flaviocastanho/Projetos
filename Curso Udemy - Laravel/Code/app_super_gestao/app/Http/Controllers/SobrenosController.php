<?php

namespace App\Http\Controllers;

use App\Http\Middleware\LogAcessoMiddleware;
use Illuminate\Http\Request;

class SobrenosController extends Controller
{
    // public function __construct()
    // {
    //     $this->middleware(LogAcessoMiddleware::class);
    // }
    // ou configurado no arquivo via kernel.php dando um APELIDO
      public function __construct()
    {
        $this->middleware('log.acesso');
    }

    public function Sobrenos(){
        return view('site.sobre-nos', ['titulo' => 'Sobre Nós']);
    }
}
