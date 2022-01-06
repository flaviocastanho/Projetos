<div>
    <!-- The only way to do great work is to love what you do. - Steve Jobs -->
    Meu primeiro componente User List
    
    <br>
    <br>
    {{$attributes}}



    
    <br>

    {{$curso}}

    @if($type === 'list')

        <ul class="list-group">
        @foreach($users as $user)
           
            <li class="list-group-item"> {{$user->id}} {{$user->name}}  {{$user->email}}</li>
            <br>
        @endforeach
        
        </ul>
    @elseif($type === 'card') 
     @foreach($users as $user)
        <div class="card bg-{{$isSelected($user->id) ? 'info' : 'warning'}}" style="width: 18rem;">
        <img src="..." class="card-img-top" alt="...">
        <div class="card-body">
           

            <h5 class="card-title">{{$user->name}}</h5>
            <p class="card-text">{{$user->email}}</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>

          
        </div>
        </div>
        @endforeach
    @endif


</div>