<?php

namespace App\View\Components\User;

use App\Models\User;
use Illuminate\View\Component;

class UserList extends Component
{
    public $users;
    public $type;
    public $curso = 'laravel';

    /*public $except = ['curso'];*/
    
    /**
     * Create a new component instance.
     *
     * @return void
     */
    public function __construct($type = 'list')
    {
        $this->users = User::All();
        $this->type = $type;
    }

    public function isSelected($userId)
    {

        return $userId === 3;
    }

    /**
     * Get the view / contents that represent the component.
     *
     * @return \Illuminate\Contracts\View\View|\Closure|string
     */
    public function render()
    {
        return view('components.user.user-list');
    }
}
