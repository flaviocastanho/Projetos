<?php

namespace App\View\Components\Laravel;

use Illuminate\View\Component;

class Doc extends Component
{
    // public $title;
    // public $description;
    /**
     * Create a new component instance.
     *
     * @return void
     */
    public function __construct()
    {
      //
    }

    /**
     * Get the view / contents that represent the component.
     *
     * @return \Illuminate\Contracts\View\View|\Closure|string
     */
    public function render()
    {
        return view('components.laravel.doc');
    }

    public function getContentAlign()
    {
        $this->attributes->get('content-align');
    }
}
