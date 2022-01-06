<?php

namespace App\View\Components\Form;

use Illuminate\View\Component;

class Button extends Component
{
    public $name;
    public $variant;
    /**
     * Create a new component instance.
     *
     * @return void
     */
    public function __construct(string $name = '', string $variant = '')
    {
        $this->name = $name;
        $this->variant = $variant;

    }

    /**
     * Get the view / contents that represent the component.
     *
     * @return \Illuminate\Contracts\View\View|\Closure|string
     */
    public function render()
    {
        return view('components.form.button');
    }
}
