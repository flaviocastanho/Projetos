<?php

namespace App\Http\Controllers;

use App\Models\MotivoContato;
use App\Models\SiteContato;
use Illuminate\Http\Request;

class ContatoController extends Controller
{
   public function Contato(Request $request){
      //  var_dump($_POST);
    //dd($_GET);
   //   dd($request->all());
   echo '<pre>';
   print_r($request->all());
   echo $request->input('nome');
   echo '</pre>';
    
      //  $contato = new SiteContato();
      // $contato->nome = $request->input('nome');
      // $contato->telefone = $request->input('telefone');
      // $contato->email = $request->input('email');
      // $contato->motivo_contato = $request->input('motivo_contato');
      // $contato->mensagem = $request->input('mensagem');
      // $contato->save();
      // print_r($contato->getAttribute(''));
      // dd($contato);
      
      //ou

      // $contato = new SiteContato();
      // $contato->create($request->all());

      // $motivo_contatos = [
      //    '1' => 'Dúvida',
      //    '2' => 'Elogio',
      //    '3' => 'Reclamação'
      // ];
       $motivo_contatos = MotivoContato::all();

       return view('site.contato', ['titulo'=>'Contato', 'motivo_contatos' => $motivo_contatos]);
   }

   public function salvar(Request $request){
      // dd($request);

      //Realizar a validação dos dados
      $request->validate([
         'nome' => 'required|min:3|max:40|unique:site_contatos,nome,except,id',
         'telefone' => 'required',
         'email' => 'required|email',
         'motivo_contatos_id' => 'required',
         'mensagem' => 'required|max:200',
      ], 
      /*Podemos tambem alterar o arquivo lang */
   [
      'nome.required' => 'O campo nome precisa ser preenchido;',
      'nome.min' => 'O campo precisa no minimo ter 3 caractres.',
      'nome.max' => 'O campo precisa no maximo ter 40 caractres.',
      'nome.unique' => 'O nome informado ja esta em uso.',

      'nome.telefone' => 'O campo telefone precisa ser preenchido;',

      /*ou */

      'required' => 'O campo :attribute deve ser preenchido'
   ]);

       SiteContato::create($request->all());
       return redirect()->route('site.index');
   }
}
