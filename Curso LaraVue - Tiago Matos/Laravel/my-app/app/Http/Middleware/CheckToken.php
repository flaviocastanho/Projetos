<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;

class CheckToken
{
    /**
     * Handle an incoming request.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  \Closure  $next
     * @return mixed
     */
    public function handle(Request $request, Closure $next)
    {
        IF ($request->input('token')==='abc'){
            return redirect('/');
        }
        // else {
        //     dd($request->server('HTTP_USER_AGENT'));
        // }
        
        return $next($request);
    }
}
