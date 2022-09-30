<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Calificacion;

class CalificacionController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $calificaciones = Calificacion::all();
        return view('calificacion.index')->with('calificaciones',$calificaciones);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('calificacion.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $calificaciones = new Calificacion();

        $calificaciones->id = $request->get('id');
        $calificaciones->nalumno = $request->get('nalumno');
        $calificaciones->nmateria = $request->get('nmateria');
        $calificaciones->pp = $request->get('pp');
        $calificaciones->sp = $request->get('sp');
        $calificaciones->tp = $request->get('tp');
        $calificaciones->calificacion = $request->get('calificacion');

        $calificaciones->save();

        return redirect('/calificaciones');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $calificacion = Calificacion::find($id);
        return view('calificacion.edit')->with('calificacion',$calificacion);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        $calificacion = Calificacion::find($id);

        $calificacion->id = $request->get('id');
        $calificacion->nalumno = $request->get('nalumno');
        $calificacion->nmateria = $request->get('nmateria');
        $calificacion->pp = $request->get('pp');
        $calificacion->sp = $request->get('sp');
        $calificacion->tp = $request->get('tp');
        $calificacion->calificacion = $request->get('calificacion');

        $calificacion->save();

        return redirect('/calificaciones');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $calificacion = Calificacion::find($id);
        $calificacion->delete();
        return redirect('/calificaciones');
    }
}
