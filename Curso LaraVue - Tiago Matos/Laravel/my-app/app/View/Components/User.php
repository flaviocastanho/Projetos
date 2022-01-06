<?php

namespace App\View\Components;

use App\Models\User as ModelsUser;
use Illuminate\View\Component;

class User extends Component
{
    public $userscomp;


    /**
     * Create a new component instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->users = ModelsUser::all();
    }

    /**
     * Get the view / contents that represent the component.
     *
     * @return \Illuminate\Contracts\View\View|\Closure|string
     */
    public function render()
    {
        return view('components.user');
    }
}
