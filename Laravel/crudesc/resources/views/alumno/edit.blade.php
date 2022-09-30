@extends('layouts.plantillabase');

@section('contenido')
<h2>EDITAR ALUMNO</h2>

<form action="/alumnos/{{$alumno->id}}" method="POST">
    @csrf
    @method('PUT')
<div class=mb-3>
    <label for="" class="form-label">Id</label>
    <input id="id" name="id" type="text" class="form-control" value="{{$alumno->id}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">Nombre</label>
    <input id="nombre" name="nombre" type="text" class="form-control" value="{{$alumno->nombre}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">Apellido_paterno</label>
    <input id="apellido_paterno" name="apellido_paterno" type="text" class="form-control" value="{{$alumno->apellido_paterno}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">Apellido_materno</label>
    <input id="apellido_materno" name="apellido_materno" type="text" class="form-control" value="{{$alumno->apellido_materno}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">Edad</label>
    <input id="edad" name="edad" type="number" class="form-control" value="{{$alumno->edad}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">Sexo</label>
    <input id="sexo" name="sexo" type="listBox" class="form-control" value="{{$alumno->sexo}}">
</div>
<a href="/alumnos" class="btn btn-secondary" tabindex="5">Cancelar</a>
<button type="submit" class="btn btn-primary" tabindex="4">Guardar</button>
</form>

@endsection