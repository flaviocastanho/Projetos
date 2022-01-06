<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;

class AutenticacaoMiddleware
{
    /**
     * Handle an incoming request.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  \Closure  $next
     * @return mixed
     */
    public function handle(Request $request, Closure $next, $metodo_autenticacao, $perfil)    
    {
        
        // dd($metodo_autenticacao);

        // echo($metodo_autenticacao.'-'.$perfil.'<br>');

        // if($metodo_autenticacao == 'padrao'){
        //     echo('Verificar o usuario e senha no banco de dados');
        // }

        // if($metodo_autenticacao == 'ldap'){
        //     echo('Verificar o usuario e senha no AD');
        // }

        // if(true){
        //     return $next($request);
        // } 
        // else {
        //     return response('Acesso Negado! Rota exige autenticação!!!');
        // }

        session_start();
        if (isset($_SESSION['email']) && $_SESSION['email'] != '') {
            return $next($request);
        }
        else {
            return redirect()->route('site.login', ['erro' => 2]);
        }
    }
}
