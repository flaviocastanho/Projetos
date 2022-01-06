<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

use function GuzzleHttp\Promise\all;

class LoginController extends Controller
{
    public function index(Request $request){
        $erro = $request->get('erro');

        if ($erro == 1){
            $erro = 'Usuário e ou senha não existe';
        }

        if ($erro == 2){
            $erro = 'Necessario realizar o login pra ter acesso a pagina';
        }

        return view('site.login',['titulo'=>'Home','erro' => $erro]);
    }

    public function autenticar(Request $request){
        
        //Regras de validação
        $regras = [
            'usuario' => 'email',
            'senha' => 'required'
        ];

        $feedback =[
            'usuario.email' => 'O campo :attribute (e-mail) é obrigatorio.',
            'senha' => 'O campo :attribute é obrigatorio'
        ];

        $request->validate($regras,$feedback);

        $email = $request->get('usuario');
        $password = $request->get('senha');

        // echo "Usuario: $email | Senha: $password ";

        // print_r($request->all());

        // Inciciar model users
        $user = new User();
        $usuario = $user->where('email',$email)
                        ->where('password',$password)
                        ->get()
                        ->first();

        if (isset($usuario->name)){
            // echo 'Usuario existe';
            
            session_start();
            $_SESSION['nome'] = $usuario->name;
            $_SESSION['email'] = $usuario->email;

            return redirect()->route('app.home');
        }
        else{
            // echo 'Usuario nao existe';
            return redirect()->route('site.login',['erro'=> 1]);
        }

        

        // echo '<pre>';
        // print_r($usuario);
        // echo '</pre>';




    }

     public function sair(){
         session_destroy();
         return redirect()->route('site.index');
     }
}
