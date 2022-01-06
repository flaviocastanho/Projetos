<?php

namespace App\Http\Controllers;

use App\Models\noticia;
use App\Http\Requests\StorenoticiaRequest;
use App\Http\Requests\UpdatenoticiaRequest;
use Illuminate\Support\Facades\Cache;

class NoticiaController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        // $noticias = [];

        
        //Criar um dado dentro do bd Redis
        // Cache::put('site','flavio.net.br',10);
        //chave, valor, tempo em segundos para expirar o dado em memoria

        // recupear um dado dentro do bd Redis

        // $site = Cache::get('site');
        // echo $site;
        $noticias = [];

        // if (Cache::has('dez_primeiras_noticias')){
        //     $noticias = Cache::get('dez_primeiras_noticias');
        // } else {
        //     $noticias = Noticia::orderByDesc('created_at')->limit(10)->get();

        //     Cache::put('dez_primeiras_noticias', $noticias, 15);
        // }
        
        $noticias = Cache::remember('dez_primeiras_noticias',15, function(){
            return Noticia::orderByDesc('created_at')->limit(10)->get();
        });
        

        return view('noticia', ['noticias' => $noticias]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \App\Http\Requests\StorenoticiaRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StorenoticiaRequest $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\noticia  $noticia
     * @return \Illuminate\Http\Response
     */
    public function show(noticia $noticia)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  \App\Models\noticia  $noticia
     * @return \Illuminate\Http\Response
     */
    public function edit(noticia $noticia)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \App\Http\Requests\UpdatenoticiaRequest  $request
     * @param  \App\Models\noticia  $noticia
     * @return \Illuminate\Http\Response
     */
    public function update(UpdatenoticiaRequest $request, noticia $noticia)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\noticia  $noticia
     * @return \Illuminate\Http\Response
     */
    public function destroy(noticia $noticia)
    {
        //
    }
}
