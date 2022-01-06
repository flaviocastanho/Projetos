@extends('layouts.auth')

@section('content')
    <main class="form-signin">
     
     {{url('login')}} <br>
     {{route('login.index')}}

    <form method="POST" action=" {{route('login.index')}}">
        {{--Tecnica de sergunça--}}
        @csrf

        <img class="mb-4" src="https://getbootstrap.com/docs/5.1/assets/brand/bootstrap-logo.svg" alt="" width="72" height="57">
        <h1 class="h3 mb-3 fw-normal">Please sign in</h1>
        

        @if($errors->any())
        <ul>
            @foreach($errors->all() as $error)
             <li class="text-danger">
                {{$error}}
             </li>
            @endforeach
        </ul>
        @endif

        <div class="form-floating">
        <input 
            type="email" 
            class="form-control @error('email') is-invalid @enderror" id="floatingInput" 
            placeholder="name@example.com" 
            name="email"
            value="{{old('email')}}"
        >
        
        <label for="floatingInput">Email address</label>
        </div>

        @error('email')
        <div class="text-danger">
            {{$message}}
        </div>
        @enderror

        <div class="form-floating">
        <input type="password" class="form-control @error('password') is-invalid @enderror" id="floatingPassword" placeholder="Password" name="password">
        <label for="floatingPassword">Password</label>
        </div>
       @error('password')
            <div class="text-danger">
            {{$message}}
        </div>
        @enderror
        <div class="checkbox mb-3">
        <label>
            <input type="checkbox" value="remember-me"> Remember me
        </label>
        </div>
        <button class="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>
        <p class="mt-5 mb-3 text-muted">&copy; 2017–2021</p>
    </form>
    </main>
@endsection