<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Alumno;

class AlumnoController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $alumnos = Alumno::all();
        return view('alumno.index')->with('alumnos',$alumnos);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('alumno.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $alumnos = new Alumno();
        $alumnos->id = $request->get('id');
        $alumnos->nombre = $request->get('nombre');
        $alumnos->apellido_paterno = $request->get('apellido_paterno');
        $alumnos->apellido_materno = $request->get('apellido_materno');
        $alumnos->edad = $request->get('edad');
        $alumnos->sexo = $request->get('sexo');

        $alumnos->save();
        return redirect('/alumnos');
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
        $alumno = Alumno::find($id);
        return view('alumno.edit')->with('alumno',$alumno);
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
        $alumno = Alumno::find($id);
        $alumno->id = $request->get('id');
        $alumno->nombre = $request->get('nombre');
        $alumno->apellido_paterno = $request->get('apellido_paterno');
        $alumno->apellido_materno = $request->get('apellido_materno');
        $alumno->edad = $request->get('edad');
        $alumno->sexo = $request->get('sexo');

        $alumno->save();
        return redirect('/alumnos');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
       $alumno = Alumno::find($id);
       $alumno->delete();
       return redirect('/alumnos');
    }
}
